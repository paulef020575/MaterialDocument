using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialDocument.Classes;
using System.IO;
using System.Data.Common;

namespace MaterialDocument
{
    public partial class MaterialPermitForm : Form
    {
        private MaterialDocumentDatabase Database;

        public MaterialPermit Document
        {
            get { return (MaterialPermit)bsDocument.DataSource; }
            set
            {
                bsDocument.DataSource = value;
                bsItemList.DataSource = Document.GetItemList(Database);
                CheckAutoPermit();
            }
        }

        private void CheckAutoPermit()
        {
            if (Document.AutoPermitId != 0)
            {
                AutoPermit autoPermit = Document.LoadAutoPermit(Database);
                chkAutoPermit.Checked = true;
                tboxAutoPermit.Text = autoPermit.ToString();
                tboxAutoPermit.Enabled = false;
                btnFindPermit.Enabled = false;
            }
            else
            {
                chkAutoPermit.Checked = false;
            }
        }

        private MaterialPermitForm()
        {
            InitializeComponent();

            ShowImages();
            CreateBindings();

            LoadAutoCompleteList();
        }

        private void LoadAutoCompleteList()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "EPV.MateruialDocument");
            if (Directory.Exists(path))
            {
                string fileName = Path.Combine(path, "ItemList.txt");
                List<MaterialSource> source = new List<MaterialSource>();
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);

                    foreach (string line in lines)
                        source.Add(new MaterialSource(line));

                    if (source.Count > 0)
                        lboxAutoComplete.DataSource = source;

                    return;
                }
            }

            lboxAutoComplete.Visible = false;
        }

        private void SaveAutoCompleteList()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "EPV.MateruialDocument");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string fileName = Path.Combine(path, "ItemList.txt");

            List<MaterialSource> list = new List<MaterialSource>();
            foreach (MaterialPermitItem item in bsItemList)
                list.Add(new MaterialSource(item));

            if (lboxAutoComplete.DataSource != null)
            {
                foreach (MaterialSource source in (List<MaterialSource>)lboxAutoComplete.DataSource)
                {
                    if (!list.Contains(source))
                        list.Add(source);
                }
            }

            List<string> lines = new List<string>();
            foreach (MaterialSource line in list)
                lines.Add(line.ToFile());

            File.WriteAllLines(fileName, lines.ToArray());
        }

        public MaterialPermitForm(MaterialDocumentDatabase database, MaterialPermit document)
            : this()
        {
            Database = database;
            Document = document;

            FillAutoPermit();

        }

        private void ShowImages()
        {
            addItemTool.Image = MaterialDocument.Resources.Image.Add;
            deleteItemTool.Image = MaterialDocument.Resources.Image.Delete;
        }

        private void CreateBindings()
        {
            btnSave.DataBindings.Add("Enabled", bsDocument, "IsModified", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOK.DataBindings.Add("Enabled", bsDocument, "IsModified", false, DataSourceUpdateMode.OnPropertyChanged);

            tboxBaseDocument.DataBindings.Add("Text", bsDocument, "BaseDocument", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxBaseDocNumber.DataBindings.Add("Text", bsDocument, "BaseDocNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            pickBaseDocDate.DataBindings.Add("Value", bsDocument, "BaseDocDate", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FillAutoPermit()
        {
            string query = MaterialDocument.Resources.Doc.MaterialPermit.GetBaseDocumentList;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            using (DbDataReader reader = Database.ExecuteReader(query))
            {
                while (reader.Read())
                    collection.Add((string)reader[0]);
                reader.Close();
            }

            tboxBaseDocument.AutoCompleteCustomSource = collection;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void SaveDocument()
        {
            Document.Save(Database);
            SaveAutoCompleteList();
            OnDocumentSaved();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveDocument();
            Close();
        }

        private void MaterialPermitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Document.IsModified)
            {
                DialogResult result = MessageBox.Show(MaterialDocument.Resources.Question.SaveItem, Document.ToString(),
                                                MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        Document.Save(Database);
                        e.Cancel = false;
                        break;

                    case DialogResult.No:
                        e.Cancel = false;
                        break;

                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void addItemTool_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void AddNewItem()
        {
            bsItemList.Position = bsItemList.IndexOf(Document.AddItem());
            dgvItemList.Select();
        }

        private void AddNewItem(MaterialSource source)
        {
            MaterialPermitItem item = Document.AddItem();
            item.Material = source.Material;
            item.MaterialUnit = source.MaterialUnit;

            bsItemList.Position = bsItemList.IndexOf(item);
            dgvItemList.Select();
        }

        private void deleteItemTool_Click(object sender, EventArgs e)
        {
            DeleteCurrentItem();
        }

        private void DeleteCurrentItem()
        {
            if (bsItemList.Current != null
                && MessageBox.Show(MaterialDocument.Resources.Question.DeleteItem, Document.ToString(),
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Document.DeleteItem((MaterialPermitItem)bsItemList.Current);                
        }

        private void bsItemList_CurrentChanged(object sender, EventArgs e)
        {
            deleteItemTool.Enabled = (bsItemList.Current != null);
        }

        private EventHandler<DocumentEventArgs> onDocumentSaved;

        public event EventHandler<DocumentEventArgs> DocumentSaved
        {
            add { onDocumentSaved += value; }
            remove { onDocumentSaved -= value; }
        }

        private void OnDocumentSaved()
        {
            if (onDocumentSaved != null)
                onDocumentSaved(this, new DocumentEventArgs(Document));
        }

        private void chkAutoPermit_CheckedChanged(object sender, EventArgs e)
        {
            tboxAutoPermit.Enabled = chkAutoPermit.Checked;
            btnFindPermit.Enabled = chkAutoPermit.Checked;

        }

        private void btnFindPermit_Click(object sender, EventArgs e)
        {
            int docNum;
            if (int.TryParse(tboxAutoPermit.Text, out docNum))
            {
                List<AutoPermit> permitList = AutoPermit.LoadList(Database, docNum);

                if (permitList.Count == 0)
                {
                    MessageBox.Show("Не найден пропуск с указанным номером");
                    tboxAutoPermit.Select(0, tboxAutoPermit.Text.Length);
                    return;
                }

                if (permitList.Count == 1)
                    LinkAutoPermit(permitList[0]);
                else
                {
                    SelectPermitForm form = new SelectPermitForm(permitList);
                    if (form.ShowDialog() == DialogResult.OK)
                        LinkAutoPermit(form.SelectedPermit);
                    else
                        tboxAutoPermit.Select(0, tboxAutoPermit.Text.Length);
                }
            }
            else
            {
                MessageBox.Show("Неверный формат номера документа");
                tboxAutoPermit.Select(0, tboxAutoPermit.Text.Length);
            }
        }

        private void LinkAutoPermit(AutoPermit autoPermit)
        {
            if (!Document.CheckAutoPermitProperties(autoPermit))
            {
                DocumentPropertiesForm form = new DocumentPropertiesForm(Database, Document, autoPermit);
                if (form.ShowDialog() == DialogResult.Cancel)
                    return;
            }

            autoPermit.GetVehicle(Database);
            Document.LinkAutoPermit(autoPermit);
            tboxAutoPermit.Text = autoPermit.ToString();
            btnFindPermit.Enabled = false;
        }

        private void tboxAutoPermit_TextChanged(object sender, EventArgs e)
        {
            if (tboxAutoPermit.Text.Length > 0)
                btnFindPermit.Enabled = true;
        }

        private void chkAutoPermit_Click(object sender, EventArgs e)
        {
            if (chkAutoPermit.Checked == false
                && Document.AutoPermitId > 0
                && MessageBox.Show("Отключить привязку к автопропуску?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                chkAutoPermit.Checked = true;
            }
            else
            {
                tboxAutoPermit.Clear();
                Document.ClearAutoPermit();
            }

        }

        #region Автозаполнение

        private class MaterialSource
        {
            public string Material { get; private set; }
            public string MaterialUnit { get; private set; }

            public MaterialSource(string line)
            {
                string[] words = line.Split(new char[] { '\t' });
                Material = words[0];
                MaterialUnit = words[1];
            }

            public MaterialSource(MaterialPermitItem item)
            {
                Material = item.Material;
                MaterialUnit = item.MaterialUnit;
            }

            public string ToFile()
            {
                return Material + '\t' + MaterialUnit;
            }

            public override string  ToString()
            {
                return Material;
            }

            public override bool Equals(object obj)
            {
                MaterialSource source = obj as MaterialSource;
                if (source != null)
                    return string.Equals(Material, source.Material, StringComparison.CurrentCultureIgnoreCase);

                return false;
            }

            public override int GetHashCode()
            {
                return Material.GetHashCode();
            }
        }



        #endregion

        private void lboxAutoComplete_DoubleClick(object sender, EventArgs e)
        {
            AddNewItem((MaterialSource)lboxAutoComplete.SelectedItem);
        }

        private void tboxAutoPermit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && tboxAutoPermit.Text.Length > 0)
                btnFindPermit_Click(sender, EventArgs.Empty);
        }
    }

}
