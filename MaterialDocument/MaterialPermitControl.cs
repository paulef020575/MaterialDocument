using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using MaterialDocument.Classes;

namespace MaterialDocument
{
    public partial class MaterialPermitControl : UserControl
    {
        public MaterialDocumentDatabase Database { get; private set; }

        private int secondsToSeen = 10;

        public MaterialPermit Document
        {
            get { return (MaterialPermit)bsDocument.DataSource; }
            set 
            { 
                bsDocument.DataSource = value;

                int userRole = Document.Unit.GetRole(Database);
                btnCreate.Enabled = Document.CanCreate(userRole);
                btnSign.Enabled = Document.CanSign(userRole);

                btnFailCreate.Enabled = Document.CanFailCreate(userRole);
                btnFailSign.Enabled = Document.CanFailSign(userRole);

                lblCreator.Text = Document.CreationInfo;// Document.Creator.ToString();
                lblSigner.Text = Document.SignInfo; // Document.Signer.ToString();
                lblEntryPoint.Text = Document.EntryInfo; // Document.EntryPoint.ToString();

                tboxBaseDocument.DataBindings.Add("Text", bsDocument, "BaseDocument");
                tboxBaseDocNumber.DataBindings.Add("Text", bsDocument, "BaseDocNumber");
                pickBaseDocDate.DataBindings.Add("Value", bsDocument, "BaseDocDate");

                //pnlSigning.Visible = !Document.IsModified;

                //pnlTop.Enabled = Document.CanEdit(Database);
                //pnlItems.Enabled = Document.CanEdit(Database);
                //commentPnl.Enabled = Document.CanEdit(Database);

                if (Document.IsNew)
                    seenTimer.Start();
            }
        }

        private MaterialPermitControl()
        {
            InitializeComponent();

            ShowImages();
        }

        private void ShowImages()
        {
            pctCreateFlag.DataBindings.Add("Image", bsDocument, "CreateFlagImage");
            pctSignFlag.DataBindings.Add("Image", bsDocument, "SignedFlagImage");
            pctEntryFlag.DataBindings.Add("Image", bsDocument, "EntryFlagImage");
        }

        public MaterialPermitControl(MaterialDocumentDatabase database, MaterialPermit document)
            : this()
        {
            Database = database;
            Document = document;
            bsItemList.DataSource = Document.GetItemList(Database);
        }

        //private void addItemTool_Click(object sender, EventArgs e)
        //{
        //    if (Validate())
        //    {
        //        bsItemList.Position = bsItemList.IndexOf(Document.AddItem());
        //        dgvItemList.Select();
        //    }
        //}

        //private void deleteItemTool_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show(MaterialDocument.Resources.Question.DeleteItem, "Внимание",
        //                        MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        DeleteCurrentItem();
        //}

        //private void DeleteCurrentItem()
        //{
        //    Document.DeleteItem((MaterialPermitItem)bsItemList.Current);
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    Document.Save(Database);
        //    DocumentPropertyChanged(this, new PropertyChangedEventArgs("IsModified"));
        //}


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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Document.MarkCreated(Database, 1);
            OnDocumentSaved();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Document.MarkSigned(Database, 1);
            OnDocumentSaved();
        }

        private void btnFailCreate_Click(object sender, EventArgs e)
        {
            Document.MarkCreated(Database, -1);
            OnDocumentSaved();
        }

        private void btnFailSign_Click(object sender, EventArgs e)
        {
            Document.MarkSigned(Database, -1);
            OnDocumentSaved();
        }

        private void seenTimer_Tick(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState != FormWindowState.Minimized)
                secondsToSeen--;
            else
                secondsToSeen = 10;

            if (secondsToSeen <= 0)
                SetDocumentAsSeen();
        }

        private void SetDocumentAsSeen()
        {
            seenTimer.Stop();
            try
            {
                Document.SetAsSeen(Database);
                OnSeenDocument();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка базы данных: " + exc.Message);
            }
        }
        

        private EventHandler<DocumentEventArgs> onSeenDocument;

        public event EventHandler<DocumentEventArgs> SeenDocument
        {
            add { onSeenDocument += value; }
            remove { onSeenDocument -= value; }
        }

        private void OnSeenDocument()
        {
            if (onSeenDocument != null)
                onSeenDocument(this, new DocumentEventArgs(Document));
        }

        internal void StopTimer()
        {
            seenTimer.Stop();
        }
    }
}
