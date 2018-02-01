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
    public partial class SelectPermitForm : Form
    {
        private SelectPermitForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public SelectPermitForm(List<AutoPermit> permitList)
            : this()
        {
            dataGridView1.DataSource = permitList;
        }

        public AutoPermit SelectedPermit
        {
            get
            {
                List<AutoPermit> permitList = (List<AutoPermit>)dataGridView1.DataSource;

                return permitList[dataGridView1.CurrentCell.RowIndex];
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
                

     }
}
