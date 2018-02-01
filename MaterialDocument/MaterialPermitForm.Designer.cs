namespace MaterialDocument
{
    partial class MaterialPermitForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialPermitForm));
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.GroupBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.MaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItemList = new System.Windows.Forms.BindingSource(this.components);
            this.itemListTools = new System.Windows.Forms.ToolStrip();
            this.addItemTool = new System.Windows.Forms.ToolStripButton();
            this.deleteItemTool = new System.Windows.Forms.ToolStripButton();
            this.lboxAutoComplete = new System.Windows.Forms.ListBox();
            this.commentPnl = new System.Windows.Forms.GroupBox();
            this.tboxComment = new EPV.Controls.DataBindedTextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAutoPermit = new System.Windows.Forms.CheckBox();
            this.btnFindPermit = new System.Windows.Forms.Button();
            this.tboxAutoPermit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pickBaseDocDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxBaseDocNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxBaseDocument = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tboxDocNumber = new EPV.Controls.DataBindedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxLicensePlate = new EPV.Controls.DataBindedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBindedDateTimePicker1 = new EPV.Controls.DataBindedDateTimePicker();
            this.tboxVehicleMark = new EPV.Controls.DataBindedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPerson = new EPV.Controls.DataBindedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).BeginInit();
            this.itemListTools.SuspendLayout();
            this.commentPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxComment)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxDocNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxLicensePlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindedDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxVehicleMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 516);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Size = new System.Drawing.Size(768, 35);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(463, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(563, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(663, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.pnlItems);
            this.pnlData.Controls.Add(this.commentPnl);
            this.pnlData.Controls.Add(this.pnlTop);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(768, 516);
            this.pnlData.TabIndex = 0;
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.dgvItemList);
            this.pnlItems.Controls.Add(this.itemListTools);
            this.pnlItems.Controls.Add(this.lboxAutoComplete);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(0, 140);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(768, 289);
            this.pnlItems.TabIndex = 23;
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
            this.dgvItemList.Location = new System.Drawing.Point(3, 41);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.Size = new System.Drawing.Size(597, 245);
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
            // bsItemList
            // 
            this.bsItemList.DataSourceChanged += new System.EventHandler(this.bsItemList_CurrentChanged);
            this.bsItemList.CurrentChanged += new System.EventHandler(this.bsItemList_CurrentChanged);
            // 
            // itemListTools
            // 
            this.itemListTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemTool,
            this.deleteItemTool});
            this.itemListTools.Location = new System.Drawing.Point(3, 16);
            this.itemListTools.Name = "itemListTools";
            this.itemListTools.Size = new System.Drawing.Size(597, 25);
            this.itemListTools.TabIndex = 2;
            this.itemListTools.Text = "toolStrip1";
            // 
            // addItemTool
            // 
            this.addItemTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addItemTool.Image = ((System.Drawing.Image)(resources.GetObject("addItemTool.Image")));
            this.addItemTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addItemTool.Name = "addItemTool";
            this.addItemTool.Size = new System.Drawing.Size(23, 22);
            this.addItemTool.Text = "Добавить";
            this.addItemTool.Click += new System.EventHandler(this.addItemTool_Click);
            // 
            // deleteItemTool
            // 
            this.deleteItemTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemTool.Image")));
            this.deleteItemTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItemTool.Name = "deleteItemTool";
            this.deleteItemTool.Size = new System.Drawing.Size(23, 22);
            this.deleteItemTool.Text = "Удалить";
            this.deleteItemTool.Click += new System.EventHandler(this.deleteItemTool_Click);
            // 
            // lboxAutoComplete
            // 
            this.lboxAutoComplete.Dock = System.Windows.Forms.DockStyle.Right;
            this.lboxAutoComplete.FormattingEnabled = true;
            this.lboxAutoComplete.Location = new System.Drawing.Point(600, 16);
            this.lboxAutoComplete.Name = "lboxAutoComplete";
            this.lboxAutoComplete.Size = new System.Drawing.Size(165, 270);
            this.lboxAutoComplete.TabIndex = 4;
            this.lboxAutoComplete.TabStop = false;
            this.lboxAutoComplete.DoubleClick += new System.EventHandler(this.lboxAutoComplete_DoubleClick);
            // 
            // commentPnl
            // 
            this.commentPnl.Controls.Add(this.tboxComment);
            this.commentPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentPnl.Location = new System.Drawing.Point(0, 429);
            this.commentPnl.Name = "commentPnl";
            this.commentPnl.Size = new System.Drawing.Size(768, 87);
            this.commentPnl.TabIndex = 24;
            this.commentPnl.TabStop = false;
            this.commentPnl.Text = "Комментарий";
            // 
            // tboxComment
            // 
            this.tboxComment.AcceptsReturn = true;
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Location = new System.Drawing.Point(3, 16);
            this.tboxComment.Multiline = true;
            this.tboxComment.MyDataSource = this.bsDocument;
            this.tboxComment.MyPropertyName = "Comment";
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(762, 68);
            this.tboxComment.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel2);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(768, 140);
            this.pnlTop.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.chkAutoPermit);
            this.panel2.Controls.Add(this.btnFindPermit);
            this.panel2.Controls.Add(this.tboxAutoPermit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(500, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 140);
            this.panel2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(0, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "* укажите номер автомобиля или номер пропуска";
            // 
            // chkAutoPermit
            // 
            this.chkAutoPermit.AutoSize = true;
            this.chkAutoPermit.Location = new System.Drawing.Point(14, 7);
            this.chkAutoPermit.Name = "chkAutoPermit";
            this.chkAutoPermit.Size = new System.Drawing.Size(178, 17);
            this.chkAutoPermit.TabIndex = 3;
            this.chkAutoPermit.Text = "К автомобильному пропуску *";
            this.chkAutoPermit.UseVisualStyleBackColor = true;
            this.chkAutoPermit.CheckedChanged += new System.EventHandler(this.chkAutoPermit_CheckedChanged);
            this.chkAutoPermit.Click += new System.EventHandler(this.chkAutoPermit_Click);
            // 
            // btnFindPermit
            // 
            this.btnFindPermit.Enabled = false;
            this.btnFindPermit.Location = new System.Drawing.Point(85, 56);
            this.btnFindPermit.Name = "btnFindPermit";
            this.btnFindPermit.Size = new System.Drawing.Size(100, 23);
            this.btnFindPermit.TabIndex = 2;
            this.btnFindPermit.TabStop = false;
            this.btnFindPermit.Text = "Найти";
            this.btnFindPermit.UseVisualStyleBackColor = true;
            this.btnFindPermit.Click += new System.EventHandler(this.btnFindPermit_Click);
            // 
            // tboxAutoPermit
            // 
            this.tboxAutoPermit.Enabled = false;
            this.tboxAutoPermit.Location = new System.Drawing.Point(14, 30);
            this.tboxAutoPermit.Name = "tboxAutoPermit";
            this.tboxAutoPermit.Size = new System.Drawing.Size(171, 20);
            this.tboxAutoPermit.TabIndex = 1;
            this.tboxAutoPermit.TabStop = false;
            this.tboxAutoPermit.TextChanged += new System.EventHandler(this.tboxAutoPermit_TextChanged);
            this.tboxAutoPermit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxAutoPermit_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pickBaseDocDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tboxBaseDocNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tboxBaseDocument);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.tboxDocNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tboxLicensePlate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataBindedDateTimePicker1);
            this.panel1.Controls.Add(this.tboxVehicleMark);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxPerson);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 140);
            this.panel1.TabIndex = 19;
            // 
            // pickBaseDocDate
            // 
            this.pickBaseDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickBaseDocDate.Location = new System.Drawing.Point(291, 110);
            this.pickBaseDocDate.Name = "pickBaseDocDate";
            this.pickBaseDocDate.Size = new System.Drawing.Size(106, 20);
            this.pickBaseDocDate.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "от";
            // 
            // tboxBaseDocNumber
            // 
            this.tboxBaseDocNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxBaseDocNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxBaseDocNumber.Location = new System.Drawing.Point(100, 110);
            this.tboxBaseDocNumber.Name = "tboxBaseDocNumber";
            this.tboxBaseDocNumber.Size = new System.Drawing.Size(149, 20);
            this.tboxBaseDocNumber.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "№ документа";
            // 
            // tboxBaseDocument
            // 
            this.tboxBaseDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxBaseDocument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxBaseDocument.Location = new System.Drawing.Point(100, 84);
            this.tboxBaseDocument.Name = "tboxBaseDocument";
            this.tboxBaseDocument.Size = new System.Drawing.Size(149, 20);
            this.tboxBaseDocument.TabIndex = 20;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(32, 87);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(63, 13);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Основание";
            // 
            // tboxDocNumber
            // 
            this.tboxDocNumber.Location = new System.Drawing.Point(100, 6);
            this.tboxDocNumber.MyDataSource = this.bsDocument;
            this.tboxDocNumber.MyPropertyName = "DocNumber";
            this.tboxDocNumber.Name = "tboxDocNumber";
            this.tboxDocNumber.Size = new System.Drawing.Size(149, 20);
            this.tboxDocNumber.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер Т/С";
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Location = new System.Drawing.Point(382, 58);
            this.tboxLicensePlate.MyDataSource = this.bsDocument;
            this.tboxLicensePlate.MyPropertyName = "LicensePlate";
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(106, 20);
            this.tboxLicensePlate.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Марка Т/С";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер пропуска";
            // 
            // dataBindedDateTimePicker1
            // 
            this.dataBindedDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataBindedDateTimePicker1.Location = new System.Drawing.Point(382, 6);
            this.dataBindedDateTimePicker1.MyDataSource = this.bsDocument;
            this.dataBindedDateTimePicker1.MyPropertyName = "DocDate";
            this.dataBindedDateTimePicker1.Name = "dataBindedDateTimePicker1";
            this.dataBindedDateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dataBindedDateTimePicker1.TabIndex = 15;
            // 
            // tboxVehicleMark
            // 
            this.tboxVehicleMark.Location = new System.Drawing.Point(100, 58);
            this.tboxVehicleMark.MyDataSource = this.bsDocument;
            this.tboxVehicleMark.MyPropertyName = "VehicleMark";
            this.tboxVehicleMark.Name = "tboxVehicleMark";
            this.tboxVehicleMark.Size = new System.Drawing.Size(149, 20);
            this.tboxVehicleMark.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Предъявитель";
            // 
            // tboxPerson
            // 
            this.tboxPerson.Location = new System.Drawing.Point(100, 32);
            this.tboxPerson.MyDataSource = this.bsDocument;
            this.tboxPerson.MyPropertyName = "Person";
            this.tboxPerson.Name = "tboxPerson";
            this.tboxPerson.Size = new System.Drawing.Size(388, 20);
            this.tboxPerson.TabIndex = 16;
            // 
            // MaterialPermitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 551);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlBottom);
            this.Name = "MaterialPermitForm";
            this.Text = "MaterialPermitForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialPermitForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).EndInit();
            this.itemListTools.ResumeLayout(false);
            this.itemListTools.PerformLayout();
            this.commentPnl.ResumeLayout(false);
            this.commentPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxComment)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxDocNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxLicensePlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindedDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxVehicleMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlTop;
        private EPV.Controls.DataBindedTextBox tboxDocNumber;
        private EPV.Controls.DataBindedTextBox tboxLicensePlate;
        private System.Windows.Forms.Label label1;
        private EPV.Controls.DataBindedTextBox tboxVehicleMark;
        private System.Windows.Forms.Label label3;
        private EPV.Controls.DataBindedTextBox tboxPerson;
        private System.Windows.Forms.Label label2;
        private EPV.Controls.DataBindedDateTimePicker dataBindedDateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox pnlItems;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.ToolStrip itemListTools;
        private System.Windows.Forms.ToolStripButton addItemTool;
        private System.Windows.Forms.ToolStripButton deleteItemTool;
        private System.Windows.Forms.GroupBox commentPnl;
        private EPV.Controls.DataBindedTextBox tboxComment;
        private System.Windows.Forms.BindingSource bsItemList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFindPermit;
        private System.Windows.Forms.TextBox tboxAutoPermit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAutoPermit;
        private System.Windows.Forms.ListBox lboxAutoComplete;
        private System.Windows.Forms.TextBox tboxBaseDocument;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker pickBaseDocDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxBaseDocNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonnage;
        private System.Windows.Forms.Label label8;
    }
}