namespace MaterialDocument
{
    partial class MaterialPermitControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.GroupBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.MaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItemList = new System.Windows.Forms.BindingSource(this.components);
            this.tboxDocNumber = new EPV.Controls.DataBindedTextBox();
            this.dataBindedDateTimePicker = new EPV.Controls.DataBindedDateTimePicker();
            this.tboxPerson = new EPV.Controls.DataBindedTextBox();
            this.tboxVehicleMark = new EPV.Controls.DataBindedTextBox();
            this.tboxLicensePlate = new EPV.Controls.DataBindedTextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pickBaseDocDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxBaseDocNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxBaseDocument = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlSigning = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEntryPoint = new System.Windows.Forms.Label();
            this.pctEntryFlag = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSigner = new System.Windows.Forms.Label();
            this.pctSignFlag = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFailCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnFailSign = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCreator = new System.Windows.Forms.Label();
            this.pctCreateFlag = new System.Windows.Forms.PictureBox();
            this.commentPnl = new System.Windows.Forms.GroupBox();
            this.tboxComment = new EPV.Controls.DataBindedTextBox();
            this.seenTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxDocNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindedDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxVehicleMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxLicensePlate)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlSigning.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEntryFlag)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSignFlag)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCreateFlag)).BeginInit();
            this.commentPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxComment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер пропуска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Предъявитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Марка Т/С";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер Т/С";
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.dgvItemList);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Enabled = false;
            this.pnlItems.Location = new System.Drawing.Point(0, 207);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(701, 170);
            this.pnlItems.TabIndex = 13;
            this.pnlItems.TabStop = false;
            this.pnlItems.Text = "Грузы";
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AutoGenerateColumns = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialColumn,
            this.QuantityColumn,
            this.UnitColumn,
            this.ColumnTonnage});
            this.dgvItemList.DataSource = this.bsItemList;
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.Enabled = false;
            this.dgvItemList.Location = new System.Drawing.Point(3, 16);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(695, 151);
            this.dgvItemList.TabIndex = 3;
            // 
            // MaterialColumn
            // 
            this.MaterialColumn.DataPropertyName = "Material";
            this.MaterialColumn.HeaderText = "Наименование груза";
            this.MaterialColumn.Name = "MaterialColumn";
            this.MaterialColumn.Width = 200;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "Quantity";
            this.QuantityColumn.HeaderText = "Кол-во мест";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.Width = 50;
            // 
            // UnitColumn
            // 
            this.UnitColumn.DataPropertyName = "MaterialUnit";
            this.UnitColumn.HeaderText = "Ед. изм.";
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.Width = 50;
            // 
            // ColumnTonnage
            // 
            this.ColumnTonnage.DataPropertyName = "Tonnage";
            this.ColumnTonnage.HeaderText = "Вес (тн)";
            this.ColumnTonnage.Name = "ColumnTonnage";
            this.ColumnTonnage.Width = 50;
            // 
            // tboxDocNumber
            // 
            this.tboxDocNumber.Location = new System.Drawing.Point(109, 13);
            this.tboxDocNumber.MyDataSource = this.bsDocument;
            this.tboxDocNumber.MyPropertyName = "DocNumber";
            this.tboxDocNumber.Name = "tboxDocNumber";
            this.tboxDocNumber.Size = new System.Drawing.Size(149, 20);
            this.tboxDocNumber.TabIndex = 14;
            // 
            // dataBindedDateTimePicker
            // 
            this.dataBindedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataBindedDateTimePicker.Location = new System.Drawing.Point(391, 13);
            this.dataBindedDateTimePicker.MyDataSource = this.bsDocument;
            this.dataBindedDateTimePicker.MyPropertyName = "DocDate";
            this.dataBindedDateTimePicker.Name = "dataBindedDateTimePicker";
            this.dataBindedDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.dataBindedDateTimePicker.TabIndex = 15;
            // 
            // tboxPerson
            // 
            this.tboxPerson.Location = new System.Drawing.Point(109, 39);
            this.tboxPerson.MyDataSource = this.bsDocument;
            this.tboxPerson.MyPropertyName = "Person";
            this.tboxPerson.Name = "tboxPerson";
            this.tboxPerson.Size = new System.Drawing.Size(388, 20);
            this.tboxPerson.TabIndex = 16;
            // 
            // tboxVehicleMark
            // 
            this.tboxVehicleMark.Location = new System.Drawing.Point(109, 65);
            this.tboxVehicleMark.MyDataSource = this.bsDocument;
            this.tboxVehicleMark.MyPropertyName = "VehicleMark";
            this.tboxVehicleMark.Name = "tboxVehicleMark";
            this.tboxVehicleMark.Size = new System.Drawing.Size(149, 20);
            this.tboxVehicleMark.TabIndex = 17;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Location = new System.Drawing.Point(391, 65);
            this.tboxLicensePlate.MyDataSource = this.bsDocument;
            this.tboxLicensePlate.MyPropertyName = "LicensePlate";
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(106, 20);
            this.tboxLicensePlate.TabIndex = 18;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pickBaseDocDate);
            this.pnlTop.Controls.Add(this.label11);
            this.pnlTop.Controls.Add(this.tboxBaseDocNumber);
            this.pnlTop.Controls.Add(this.label10);
            this.pnlTop.Controls.Add(this.tboxBaseDocument);
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.tboxDocNumber);
            this.pnlTop.Controls.Add(this.tboxLicensePlate);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.tboxVehicleMark);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.tboxPerson);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.dataBindedDateTimePicker);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Enabled = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 88);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(701, 119);
            this.pnlTop.TabIndex = 19;
            // 
            // pickBaseDocDate
            // 
            this.pickBaseDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickBaseDocDate.Location = new System.Drawing.Point(457, 91);
            this.pickBaseDocDate.Name = "pickBaseDocDate";
            this.pickBaseDocDate.Size = new System.Drawing.Size(96, 20);
            this.pickBaseDocDate.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "от";
            // 
            // tboxBaseDocNumber
            // 
            this.tboxBaseDocNumber.Location = new System.Drawing.Point(327, 91);
            this.tboxBaseDocNumber.Name = "tboxBaseDocNumber";
            this.tboxBaseDocNumber.Size = new System.Drawing.Size(100, 20);
            this.tboxBaseDocNumber.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "док. №";
            // 
            // tboxBaseDocument
            // 
            this.tboxBaseDocument.Location = new System.Drawing.Point(109, 91);
            this.tboxBaseDocument.Name = "tboxBaseDocument";
            this.tboxBaseDocument.Size = new System.Drawing.Size(149, 20);
            this.tboxBaseDocument.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Основание";
            // 
            // pnlSigning
            // 
            this.pnlSigning.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlSigning.ColumnCount = 3;
            this.pnlSigning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlSigning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlSigning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlSigning.Controls.Add(this.panel5, 2, 1);
            this.pnlSigning.Controls.Add(this.panel4, 1, 1);
            this.pnlSigning.Controls.Add(this.label8, 2, 0);
            this.pnlSigning.Controls.Add(this.panel1, 0, 0);
            this.pnlSigning.Controls.Add(this.panel2, 1, 0);
            this.pnlSigning.Controls.Add(this.panel3, 0, 1);
            this.pnlSigning.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSigning.Location = new System.Drawing.Point(0, 0);
            this.pnlSigning.Name = "pnlSigning";
            this.pnlSigning.RowCount = 2;
            this.pnlSigning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.pnlSigning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSigning.Size = new System.Drawing.Size(701, 88);
            this.pnlSigning.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblEntryPoint);
            this.panel5.Controls.Add(this.pctEntryFlag);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(470, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 39);
            this.panel5.TabIndex = 7;
            // 
            // lblEntryPoint
            // 
            this.lblEntryPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntryPoint.Location = new System.Drawing.Point(42, 0);
            this.lblEntryPoint.Name = "lblEntryPoint";
            this.lblEntryPoint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEntryPoint.Size = new System.Drawing.Size(185, 39);
            this.lblEntryPoint.TabIndex = 3;
            this.lblEntryPoint.Text = "label9";
            this.lblEntryPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctEntryFlag
            // 
            this.pctEntryFlag.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctEntryFlag.Location = new System.Drawing.Point(0, 0);
            this.pctEntryFlag.Name = "pctEntryFlag";
            this.pctEntryFlag.Size = new System.Drawing.Size(42, 39);
            this.pctEntryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEntryFlag.TabIndex = 1;
            this.pctEntryFlag.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSigner);
            this.panel4.Controls.Add(this.pctSignFlag);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(237, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 39);
            this.panel4.TabIndex = 6;
            // 
            // lblSigner
            // 
            this.lblSigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSigner.Location = new System.Drawing.Point(42, 0);
            this.lblSigner.Name = "lblSigner";
            this.lblSigner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSigner.Size = new System.Drawing.Size(184, 39);
            this.lblSigner.TabIndex = 2;
            this.lblSigner.Text = "label9";
            this.lblSigner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctSignFlag
            // 
            this.pctSignFlag.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctSignFlag.Location = new System.Drawing.Point(0, 0);
            this.pctSignFlag.Name = "pctSignFlag";
            this.pctSignFlag.Size = new System.Drawing.Size(42, 39);
            this.pctSignFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSignFlag.TabIndex = 1;
            this.pctSignFlag.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(470, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 39);
            this.label8.TabIndex = 2;
            this.label8.Text = "Проходная";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnFailCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 33);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Кладовщик";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreate.Location = new System.Drawing.Point(76, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 33);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Подписать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnFailCreate
            // 
            this.btnFailCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFailCreate.Location = new System.Drawing.Point(151, 0);
            this.btnFailCreate.Name = "btnFailCreate";
            this.btnFailCreate.Size = new System.Drawing.Size(75, 33);
            this.btnFailCreate.TabIndex = 3;
            this.btnFailCreate.Text = "Отклонить";
            this.btnFailCreate.UseVisualStyleBackColor = true;
            this.btnFailCreate.Click += new System.EventHandler(this.btnFailCreate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnSign);
            this.panel2.Controls.Add(this.btnFailSign);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(237, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 33);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Служба безопасности";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSign
            // 
            this.btnSign.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSign.Location = new System.Drawing.Point(226, 0);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(0, 33);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "Подписать";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Visible = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnFailSign
            // 
            this.btnFailSign.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFailSign.Location = new System.Drawing.Point(226, 0);
            this.btnFailSign.Name = "btnFailSign";
            this.btnFailSign.Size = new System.Drawing.Size(0, 33);
            this.btnFailSign.TabIndex = 5;
            this.btnFailSign.Text = "Отклонить";
            this.btnFailSign.UseVisualStyleBackColor = true;
            this.btnFailSign.Visible = false;
            this.btnFailSign.Click += new System.EventHandler(this.btnFailSign_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCreator);
            this.panel3.Controls.Add(this.pctCreateFlag);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 39);
            this.panel3.TabIndex = 5;
            // 
            // lblCreator
            // 
            this.lblCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreator.Location = new System.Drawing.Point(42, 0);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCreator.Size = new System.Drawing.Size(184, 39);
            this.lblCreator.TabIndex = 1;
            this.lblCreator.Text = "label9";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctCreateFlag
            // 
            this.pctCreateFlag.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctCreateFlag.Location = new System.Drawing.Point(0, 0);
            this.pctCreateFlag.Name = "pctCreateFlag";
            this.pctCreateFlag.Size = new System.Drawing.Size(42, 39);
            this.pctCreateFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCreateFlag.TabIndex = 0;
            this.pctCreateFlag.TabStop = false;
            // 
            // commentPnl
            // 
            this.commentPnl.Controls.Add(this.tboxComment);
            this.commentPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentPnl.Location = new System.Drawing.Point(0, 377);
            this.commentPnl.Name = "commentPnl";
            this.commentPnl.Size = new System.Drawing.Size(701, 87);
            this.commentPnl.TabIndex = 22;
            this.commentPnl.TabStop = false;
            this.commentPnl.Text = "Комментарий";
            // 
            // tboxComment
            // 
            this.tboxComment.AcceptsReturn = true;
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Enabled = false;
            this.tboxComment.Location = new System.Drawing.Point(3, 16);
            this.tboxComment.Multiline = true;
            this.tboxComment.MyDataSource = this.bsDocument;
            this.tboxComment.MyPropertyName = "Comment";
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(695, 68);
            this.tboxComment.TabIndex = 0;
            // 
            // seenTimer
            // 
            this.seenTimer.Interval = 1000;
            this.seenTimer.Tick += new System.EventHandler(this.seenTimer_Tick);
            // 
            // MaterialPermitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.commentPnl);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSigning);
            this.Name = "MaterialPermitControl";
            this.Size = new System.Drawing.Size(701, 464);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            this.pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxDocNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindedDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxVehicleMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxLicensePlate)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSigning.ResumeLayout(false);
            this.pnlSigning.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctEntryFlag)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSignFlag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCreateFlag)).EndInit();
            this.commentPnl.ResumeLayout(false);
            this.commentPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox pnlItems;
        private EPV.Controls.DataBindedTextBox tboxDocNumber;
        private EPV.Controls.DataBindedDateTimePicker dataBindedDateTimePicker;
        private EPV.Controls.DataBindedTextBox tboxPerson;
        private EPV.Controls.DataBindedTextBox tboxVehicleMark;
        private EPV.Controls.DataBindedTextBox tboxLicensePlate;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.BindingSource bsItemList;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel pnlSigning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pctEntryFlag;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pctSignFlag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctCreateFlag;
        private System.Windows.Forms.GroupBox commentPnl;
        private EPV.Controls.DataBindedTextBox tboxComment;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Button btnFailCreate;
        private System.Windows.Forms.Button btnFailSign;
        private System.Windows.Forms.Label lblSigner;
        private System.Windows.Forms.Timer seenTimer;
        private System.Windows.Forms.TextBox tboxBaseDocument;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker pickBaseDocDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tboxBaseDocNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEntryPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonnage;
    }
}
