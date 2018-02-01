using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialDocument.Classes;

namespace MaterialDocument
{
    public partial class SetCommentForm : Form
    {
        private MaterialDocumentDatabase Database;

        private MaterialPermit Document;

        private SetCommentForm()
        {
            InitializeComponent();
        }

        public SetCommentForm(MaterialDocumentDatabase database, MaterialPermit document)
            : this()
        {
            Database = database;
            Document = document;

            Text = Document.ToString();

            tboxComment.Text = Document.GetComment(Database);
            btnSave.Enabled = false;
        }

        private void tboxComment_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private EventHandler<DocumentEventArgs> onCommentSaved;

        public event EventHandler<DocumentEventArgs> CommentSaved
        {
            add { onCommentSaved += value; }
            remove { onCommentSaved -= value; }
        }

        private void OnCommentSaved()
        {
            if (onCommentSaved != null)
                onCommentSaved(this, new DocumentEventArgs(Document));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Document.SetComment(Database, tboxComment.Text);
            OnCommentSaved();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
