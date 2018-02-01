using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using MaterialDocument.Classes;

namespace MaterialDocument
{
    public partial class DocumentPropertiesForm : Form
    {
        private MaterialPermit MaterialPermit;
        private AutoPermit AutoPermit;

        private DocumentPropertiesForm()
        {
            InitializeComponent();
        }

        public DocumentPropertiesForm(Database database, MaterialPermit materialPermit, AutoPermit autoPermit)
            : this()
        {
            MaterialPermit = materialPermit;
            AutoPermit = autoPermit;

            AutoPermit.GetVehicle(database);
            ShowTextInControls();
        }

        private void ShowTextInControls()
        {
            lblMatPermit.Text = MaterialPermit.ToString();
            lblAutoPermit.Text = AutoPermit.ToString();

            tboxMatPermitPerson.Text = MaterialPermit.Person;
            tboxAutoPermitDriver.Text = AutoPermit.DriverName;

            tboxMatPermitMark.Text = MaterialPermit.VehicleMark;
            tboxAutoPermitMark.Text = AutoPermit.VehicleMark;

            tboxMatPermitLicPlate.Text = MaterialPermit.LicensePlate;
            tboxAutoPermitLicPlate.Text = AutoPermit.LicensePlate;
        }

        private void btnUseAutoPermit_Click(object sender, EventArgs e)
        {
            MaterialPermit.Person = AutoPermit.DriverName;
            MaterialPermit.VehicleMark = AutoPermit.VehicleMark;
            MaterialPermit.LicensePlate = AutoPermit.LicensePlate;
        }
    }
}
