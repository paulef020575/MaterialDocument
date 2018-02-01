using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialDocument.Classes;
using EPV.Database;
using Stimulsoft.Report;
using System.IO;
using Stimulsoft.Report.Dictionary;
using System.Net;
using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;
using MaterialDocument.Properties;

namespace MaterialDocument
{
    public partial class StartForm : Form
    {
        #region Fields & properties

        //  объек базы данных
        private MaterialDocumentDatabase database;

        //  подключенное подразделение
        public Unit CurrentUnit { get { return (Unit)cboxUnit.SelectedItem; } }

        //  признак завершения инициализации
        private bool isInitialized = false;

        //  время последнего изменения объектов в базе данных
        private DateTime lastUpdated = DateTime.MinValue;

        //  периодичность чтения объектов из базы данных
        private int refreshingInterval = 60;

        //  остаток времени до обновления окна
        private int secondsToRefresh = 0;


        private string defaultText;

        private bool coloredNotifyIcon = true;

        #endregion

        #region Структуры для передачи параметров в фоновые задачи

        private struct RefreshingArgs
        {
            public MaterialDocumentDatabase Database;
            public DateTime LastUpdatedDate;
            public Unit Unit;
        }

        private struct GetDocumentArgs
        {
            public Database Database;
            public int DocumentId;
        }

        #endregion


        public StartForm()
        {
            this.Icon = MaterialDocument.Resources.Image.DocumentIcon;
            InitializeComponent();
            ShowImages();

            CreateDatabase();
            RefreshData();

            defaultText = Text;

           // bsDocumentList_CurrentChanged(this, EventArgs.Empty);
        }

        /// <summary>
        ///     инициирует обновление данных
        /// </summary>
        private void RefreshData()
        {
            LoadUnitList();
        }

        /// <summary>
        ///     загружает список подразделений 
        /// </summary>
        private void LoadUnitList()
        {
            List<Unit> unitList = Unit.LoadList(database, database.ConnectedUser);
            cboxUnit.DataSource = unitList;
            cboxUnit.Enabled = (unitList.Count > 1);

            if (unitList.Count == 0)
            {
                MessageBox.Show(MaterialDocument.Resources.Error.NoUnitForUser, database.ConnectedUser.ToString());
                Environment.Exit(0);
            }
        }

        /// <summary>
        ///     загружает изображения для контролов
        /// </summary>
        private void ShowImages()
        {
            notifyIcon.Icon = MaterialDocument.Resources.Image.EmptyIcon;

            lblFind.Image = MaterialDocument.Resources.Image.Find;
            addDocTool.Image = MaterialDocument.Resources.Image.Add;
            editDocTool.Image = MaterialDocument.Resources.Image.Edit;
            deleteDocTool.Image = MaterialDocument.Resources.Image.Delete;
            refreshListTool.Image = MaterialDocument.Resources.Image.Refresh;
            printTool.Image = MaterialDocument.Resources.Image.Print;
            editCommentTool.Image = MaterialDocument.Resources.Image.Text;
        }

        /// <summary>
        ///     инициализирует соединение с базой данных
        /// </summary>
        private void CreateDatabase()
        {
            string connectionString = CreateConnectionString();

            if (LogonByDomain(connectionString))
                return;

            LogonForm form = new LogonForm(connectionString);

            if (form.ShowDialog() == DialogResult.OK)
            {
                database = form.Database;
            }
            else
                Environment.Exit(0);
        }

        private bool LogonByDomain(string connectionString)
        {
            database = User.LogonByDomain(new FbDatabase(connectionString), Environment.UserDomainName.ToLower(), Environment.UserName.ToLower());

            return (database != null);
        }

        private string CreateConnectionString()
        {
            //short networkIdentifier = GetNetworkIdentifier();
            FbConnectionStringBuilder connectionStringBuilder = new FbConnectionStringBuilder();

            string[] servers = GetServerList();

#if DEBUG
            connectionStringBuilder.DataSource = "localhost";
            connectionStringBuilder.Database = @"c:\Prog\dispatcher\dispatcher.fdb";
#else
            connectionStringBuilder.DataSource = Settings.Default.Server;
            connectionStringBuilder.Database = Settings.Default.Path;
#endif
            connectionStringBuilder.UserID = Settings.Default.UserId;
            connectionStringBuilder.Password = Settings.Default.Password;

            return connectionStringBuilder.ToString();
        }

        private string[] GetServerList()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string fileName = Path.Combine(path, "servers.txt");

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length >= 0)
                    return lines;
            }

            return new[] { "172.17.0.30", "192.168.10.33", "localhost" };
        }

        /// <summary>
        ///     возвращает идентификатор сети
        /// </summary>
        /// <returns>1 - сеть ЧОПа, 2 - сеть ОАО Кондопога </returns>
        private short GetNetworkIdentifier()
        {
#if DEBUG
                return 2;
#endif

            string hostName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry hostEntry = System.Net.Dns.GetHostEntry(hostName);

            foreach (IPAddress ipAddress in hostEntry.AddressList)
                if (ipAddress.ToString().StartsWith("192.168.10")
                    || ipAddress.ToString().StartsWith("192.168.51"))
                    return 1;

            return 0;
        }

        private void addDocTool_Click(object sender, EventArgs e)
        {
            CreateMaterialPermit();
        }

        private void CreateMaterialPermit()
        {
            MaterialPermit permit = new MaterialPermit(CurrentUnit);
            ShowPermitInForm(permit);
        }

        private void ShowPermitInForm(MaterialPermit permit)
        {
            try
            {
                MaterialPermitForm form = new MaterialPermitForm(database, permit);
                form.DocumentSaved += formDocumentSaved;
                form.Show();

                Text = defaultText;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка открытия документа");
            }
        }

        private void formDocumentSaved(object sender, DocumentEventArgs e)
        {
            RefreshPermitList();
            bsDocumentList.Position = bsDocumentList.IndexOf(e.Document);
        }

        private void cboxUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isInitialized)
            {
                lastUpdated = DateTime.MinValue;
                RefreshPermitList();
            }
        }

        private void RefreshPermitList()
        {
            //bsDocumentList.DataSource = new BindingList<MaterialPermit>(MaterialPermit.LoadList(database, CurrentUnit, 
            //                                                                                      DateTime.Now.AddMonths(-1),
            //                                                                                      DateTime.Now));
            if (CurrentUnit != null)
            {
                secondsToRefresh = refreshingInterval;
                refreshTimer.Stop();
                lblRefreshing.Text = "обновляем...";

                RefreshingArgs args = new RefreshingArgs();
                args.Database = database;
                args.Unit = new Unit(CurrentUnit.Id, "");
                args.LastUpdatedDate = lastUpdated;
                lblRefreshing.Visible = true;

                bckRefreshing.RunWorkerAsync(args);
            }
        }

        private void bsDocumentList_CurrentChanged(object sender, EventArgs e)
        {
            if (isInitialized)
            {
                MaterialPermit document = (MaterialPermit)bsDocumentList.Current;

                int userRole = CurrentUnit.GetRole(database);
                editDocTool.Enabled = (document != null) && document.CanEdit(userRole);
                deleteDocTool.Enabled = (document != null) && document.CanEdit(userRole);
                printTool.Enabled = (document != null);
                editCommentTool.Enabled = (document != null);

                if (document != null)
                {
                    ShowPermitInControl(document);
                }
                else
                {
                    pnlData.Controls.Clear();
                }
            }

        }

        private void ShowPermitInControl(MaterialPermit materialPermit)
        {
            pnlData.Controls.Clear();

            try
            {
                MaterialPermitControl control = new MaterialPermitControl(database, materialPermit);
                control.Dock = DockStyle.Fill;
                control.DocumentSaved += formDocumentSaved;

                control.SeenDocument += new EventHandler<DocumentEventArgs>(control_SeenDocument);
                pnlData.Controls.Add(control);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка отображения");
            }
        }


        void control_SeenDocument(object sender, DocumentEventArgs e)
        {
            dgvDocumentList.Rows[bsDocumentList.IndexOf(e.Document)].DefaultCellStyle.Font = dgvDocumentList.DefaultCellStyle.Font;
            CheckIcon((IList<MaterialPermit>)bsDocumentList.DataSource);
        }

        private void editDocTool_Click(object sender, EventArgs e)
        {
            EditCurrentDocument();
        }

        private void EditCurrentDocument()
        {
            if (bsDocumentList.Current != null)
            {
                Text = "Открываем документ...";

                    GetDocumentArgs args = new GetDocumentArgs();
                    args.Database = database;
                    args.DocumentId = ((MaterialPermit)bsDocumentList.Current).Id;
                    bckLoadDocument.RunWorkerAsync(args);
            }
        }

        private void deleteDocTool_Click(object sender, EventArgs e)
        {
            if (bsDocumentList.Current != null)
                DeleteCurrentDocument();
        }

        private void DeleteCurrentDocument()
        {
            MaterialPermit document = (MaterialPermit)bsDocumentList.Current;
            if (MessageBox.Show(MaterialDocument.Resources.Question.DeleteItem, document.ToString(),
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    document.Delete(database);
                    bsDocumentList.Remove(document);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(MaterialDocument.Resources.Error.UnableDelete + exc.Message, document.ToString());
                }
            }
        }

        private void bckRefreshing_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshingArgs args = (RefreshingArgs)e.Argument;

            MaterialDocumentDatabase database = args.Database;
            DateTime date = DateTime.MinValue;

            string query = MaterialDocument.Resources.Doc.MaterialPermit.GetLastDate;
            QueryParameters parameters = new QueryParameters("unitId", args.Unit.Id);
            object result = database.ExecuteScalar(query, parameters);

            if (result != null)
                date = (DateTime)result;

            if (date > args.LastUpdatedDate)
                e.Result = MaterialPermit.LoadList(database, args.Unit, DateTime.Now.AddMonths(-1), DateTime.Now);
            else
                e.Result = null;
        }

        private void bckRefreshing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
                        
            if (e.Result != null)
            {
                IList<MaterialPermit> list = (IList<MaterialPermit>)e.Result;
                lastUpdated = DateTime.Now;

                MaterialPermit permit = (MaterialPermit)bsDocumentList.Current;
                isInitialized = false;
                bsDocumentList.DataSource = new BindingList<MaterialPermit>(list);
                isInitialized = true;
                if (permit != null)
                    bsDocumentList.Position = bsDocumentList.IndexOf(permit);
                bsDocumentList_CurrentChanged(bsDocumentList, EventArgs.Empty);

                CheckIcon(list);
            }

            StartTimer();
        }

        private void CheckIcon(IList<MaterialPermit> list)
        {
            bool isNew = false;

            foreach (MaterialPermit permit in list)
                isNew = (isNew || permit.IsNew);

            if (isNew)
                FlashIcon();
            else
                StopFlashing();
        }

        private void StopFlashing()
        {
            notifyTimer.Stop();
            coloredNotifyIcon = false;
            notifyIcon.Icon = MaterialDocument.Resources.Image.EmptyIcon;
        }

        private void FlashIcon()
        {
            notifyTimer.Start();
            coloredNotifyIcon = true;
            notifyIcon.Icon = MaterialDocument.Resources.Image.DocumentIcon;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            isInitialized = true;
            StartTimer();
        }

        private void refrefhTimer_Tick(object sender, EventArgs e)
        {
            secondsToRefresh--;

            if (secondsToRefresh <= 0)
                RefreshPermitList();
            else
                lblRefreshing.Text = secondsToRefresh.ToString() + " сек.";
        }

        private void StartTimer()
        {
            refreshTimer.Start();
        }

        private void refreshListTool_Click(object sender, EventArgs e)
        {
            RefreshPermitList();
        }

        private void bckLoadDocument_DoWork(object sender, DoWorkEventArgs e)
        {
            GetDocumentArgs args = (GetDocumentArgs)e.Argument;

            e.Result = MaterialPermit.Load(args.Database, args.DocumentId);
        }

        private void bckLoadDocument_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(MaterialDocument.Resources.Error.LoadError + e.Error.Message);
            }
            else
            {
                ShowPermitInForm((MaterialPermit)e.Result);
            }

            Text = defaultText;
        }

        private void printTool_Click(object sender, EventArgs e)
        {
            if (bsDocumentList.Current != null)
                PrintDocument((MaterialPermit)bsDocumentList.Current);
        }

        private void PrintDocument(MaterialPermit materialPermit)
        {
            DataSet dataSet = new DataSet("DataSet1");
            DataTable table = new DataTable("MaterialPermit");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("DocNumber", typeof(string));
            table.Columns.Add("DocDate", typeof(DateTime));
            table.Columns.Add("Person", typeof(string));
            table.Columns.Add("Unit", typeof(string));
            table.Columns.Add("VehicleMark", typeof(string));
            table.Columns.Add("LicensePlate", typeof(string));
            table.Columns.Add("Creator", typeof(string));
            table.Columns.Add("Signer", typeof(string));
            

            DataRow row = table.Rows.Add();
            row["Id"] = materialPermit.Id;
            row["DocNumber"] = materialPermit.DocNumber;
            row["DocDate"] = materialPermit.DocDate;
            row["Person"] = materialPermit.Person;
            row["Unit"] = materialPermit.Unit.ToString();
            row["VehicleMark"] = materialPermit.VehicleMark;
            row["LicensePlate"] = materialPermit.LicensePlate;
            row["Creator"] = materialPermit.Creator.ToString();
            row["Signer"] = materialPermit.Signer.ToString();

            DataTable items = new DataTable("PermitItems");
            items.Columns.Add("Material", typeof(string));
            items.Columns.Add("Quantity", typeof(decimal));
            items.Columns.Add("MaterialUnit", typeof(string));
            items.Columns.Add("Document", typeof(int));

            BindingList<MaterialPermitItem> itemList = materialPermit.GetItemList(database);

            foreach (MaterialPermitItem item in itemList)
            {
                DataRow itemRow = items.Rows.Add();
                itemRow["Material"] = item.Material;
                itemRow["Quantity"] = item.Quantity;
                itemRow["MaterialUnit"] = item.MaterialUnit;
                itemRow["Document"] = materialPermit.Id;
            }
            
            dataSet.Tables.Add(table);
            dataSet.Tables.Add(items);
            
            
            StiReport report = new StiReport();

            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, "Document.mrt");
            report.Load(path);


            report.DataSources.Clear();
            StiDataTableSource sourceTable = new StiDataTableSource("MaterialPermit", "MaterialPermit", "MaterialPermit");
            report.Dictionary.DataSources.Add(sourceTable);
            report.RegData("MaterialPermit", "MaterialPermit", table);
            sourceTable.SynchronizeColumns();

            StiDataTableSource sourceTable1 = new StiDataTableSource("PermitItems", "PermitItems", "PermitItems");
            report.Dictionary.DataSources.Add(sourceTable1);
            report.RegData("PermitItems", "PermitItems", items);
            sourceTable1.SynchronizeColumns();

            
            report.Show();
        }

        private void editCommentTool_Click(object sender, EventArgs e)
        {
            if (bsDocumentList.Current != null)
                EditComment((MaterialPermit)bsDocumentList.Current);
        }

        private void EditComment(MaterialPermit materialPermit)
        {
            SetCommentForm form = new SetCommentForm(database, materialPermit);
            form.CommentSaved += formDocumentSaved;
            form.Show();
        }

        private void dgvDocumentList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (bsDocumentList.DataSource != null
                && e.RowIndex >= 0)
            {
                MaterialPermit materialPermit = (MaterialPermit)bsDocumentList[e.RowIndex];
                if (materialPermit.IsNew)
                    dgvDocumentList.Rows[e.RowIndex].DefaultCellStyle.Font 
                        = new Font(dgvDocumentList.DefaultCellStyle.Font, FontStyle.Bold);
            }
        }

        private void notifyTimer_Tick(object sender, EventArgs e)
        {
            if (coloredNotifyIcon)
            {
                coloredNotifyIcon = false;
                notifyIcon.Icon = MaterialDocument.Resources.Image.EmptyIcon;
            }
            else
            {
                coloredNotifyIcon = true;
                notifyIcon.Icon = MaterialDocument.Resources.Image.DocumentIcon;
            }
        }

        private void pnlData_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is MaterialPermitControl)
                ((MaterialPermitControl)e.Control).StopTimer();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
