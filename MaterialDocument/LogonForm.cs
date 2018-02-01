using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using MaterialDocument.Classes;
using MaterialDocument.Properties;
using System.Data.Common;

namespace MaterialDocument
{
    public partial class LogonForm : Form
    {
        private FbDatabase securityDatabase;
        private string connectionString;

        public MaterialDocumentDatabase Database { get; private set; }

        public LogonForm()
        {
            InitializeComponent();

#if DEBUG
            securityDatabase = new FbDatabase("localhost", "c:\\Prog\\dispatcher\\dispatcher.fdb",
                                                Settings.Default.UserId, Settings.Default.Password);
#else
            securityDatabase = new FbDatabase(Settings.Default.Server, Settings.Default.Path,
                                                Settings.Default.UserId, Settings.Default.Password);
#endif

            if (!securityDatabase.CheckConnection())
            {
                MessageBox.Show(MaterialDocument.Resources.Error.ConnectionError);
                Environment.Exit(0);
            }
            else
            {
                cboxUser.DataSource = User.LoadList(securityDatabase);

                cboxUser.SelectedItem = new User(Settings.Default.LastConnected);
            }
        }

        public LogonForm(string connectionString)
        {
            InitializeComponent();
            securityDatabase = new FbDatabase(connectionString);
            if (!securityDatabase.CheckConnection())
            {
                MessageBox.Show(MaterialDocument.Resources.Error.ConnectionError);
                Environment.Exit(0);
            }
            else
            {
                cboxUser.DataSource = User.LoadList(securityDatabase);

                cboxUser.SelectedItem = new User(Settings.Default.LastConnected);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                User user = (User)cboxUser.SelectedItem;

                string connectionString = user.Logon(securityDatabase, tboxPassword.Text);

                Database = new MaterialDocumentDatabase(connectionString, user);

                SetUserLikeConnected(user);

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка соединения");
            }
        }

        private void SetUserLikeConnected(User user)
        {
            Settings.Default.LastConnected = user.Id;
            Settings.Default.Save();
        }
    }
}
