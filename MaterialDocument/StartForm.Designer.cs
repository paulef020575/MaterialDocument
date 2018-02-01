namespace MaterialDocument
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.dgvDocumentList = new System.Windows.Forms.DataGridView();
            this.bsDocumentList = new System.Windows.Forms.BindingSource(this.components);
            this.documentToolStrip = new System.Windows.Forms.ToolStrip();
            this.addDocTool = new System.Windows.Forms.ToolStripButton();
            this.editDocTool = new System.Windows.Forms.ToolStripButton();
            this.deleteDocTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editCommentTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshListTool = new System.Windows.Forms.ToolStripButton();
            this.lblRefreshing = new System.Windows.Forms.ToolStripLabel();
            this.printTool = new System.Windows.Forms.ToolStripButton();
            this.findToolStrip = new System.Windows.Forms.ToolStrip();
            this.lblFind = new System.Windows.Forms.ToolStripLabel();
            this.tbox = new System.Windows.Forms.ToolStripTextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.bckRefreshing = new System.ComponentModel.BackgroundWorker();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.bckLoadDocument = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyTimer = new System.Windows.Forms.Timer(this.components);
            this.ColumnDocNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreator = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSigner = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnEntry = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentList)).BeginInit();
            this.documentToolStrip.SuspendLayout();
            this.findToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dgvDocumentList);
            this.pnlLeft.Controls.Add(this.documentToolStrip);
            this.pnlLeft.Controls.Add(this.findToolStrip);
            this.pnlLeft.Controls.Add(this.btnChangePassword);
            this.pnlLeft.Controls.Add(this.cboxUnit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(374, 522);
            this.pnlLeft.TabIndex = 0;
            // 
            // dgvDocumentList
            // 
            this.dgvDocumentList.AllowUserToAddRows = false;
            this.dgvDocumentList.AllowUserToDeleteRows = false;
            this.dgvDocumentList.AutoGenerateColumns = false;
            this.dgvDocumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDocNumber,
            this.ColumnDocDate,
            this.ColumnCreator,
            this.ColumnSigner,
            this.ColumnEntry});
            this.dgvDocumentList.DataSource = this.bsDocumentList;
            this.dgvDocumentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocumentList.Location = new System.Drawing.Point(0, 71);
            this.dgvDocumentList.Name = "dgvDocumentList";
            this.dgvDocumentList.ReadOnly = true;
            this.dgvDocumentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentList.Size = new System.Drawing.Size(374, 417);
            this.dgvDocumentList.TabIndex = 4;
            this.dgvDocumentList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDocumentList_RowPrePaint);
            // 
            // bsDocumentList
            // 
            this.bsDocumentList.DataSourceChanged += new System.EventHandler(this.bsDocumentList_CurrentChanged);
            this.bsDocumentList.CurrentChanged += new System.EventHandler(this.bsDocumentList_CurrentChanged);
            // 
            // documentToolStrip
            // 
            this.documentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDocTool,
            this.editDocTool,
            this.deleteDocTool,
            this.toolStripSeparator2,
            this.editCommentTool,
            this.toolStripSeparator1,
            this.refreshListTool,
            this.lblRefreshing,
            this.printTool});
            this.documentToolStrip.Location = new System.Drawing.Point(0, 46);
            this.documentToolStrip.Name = "documentToolStrip";
            this.documentToolStrip.Size = new System.Drawing.Size(374, 25);
            this.documentToolStrip.TabIndex = 3;
            this.documentToolStrip.Text = "toolStrip2";
            // 
            // addDocTool
            // 
            this.addDocTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addDocTool.Image = ((System.Drawing.Image)(resources.GetObject("addDocTool.Image")));
            this.addDocTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDocTool.Name = "addDocTool";
            this.addDocTool.Size = new System.Drawing.Size(23, 22);
            this.addDocTool.Text = "Новый документ";
            this.addDocTool.Click += new System.EventHandler(this.addDocTool_Click);
            // 
            // editDocTool
            // 
            this.editDocTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editDocTool.Image = ((System.Drawing.Image)(resources.GetObject("editDocTool.Image")));
            this.editDocTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editDocTool.Name = "editDocTool";
            this.editDocTool.Size = new System.Drawing.Size(23, 22);
            this.editDocTool.Text = "Изменить документ";
            this.editDocTool.Click += new System.EventHandler(this.editDocTool_Click);
            // 
            // deleteDocTool
            // 
            this.deleteDocTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteDocTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteDocTool.Image")));
            this.deleteDocTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteDocTool.Name = "deleteDocTool";
            this.deleteDocTool.Size = new System.Drawing.Size(23, 22);
            this.deleteDocTool.Text = "Удалить документ";
            this.deleteDocTool.Click += new System.EventHandler(this.deleteDocTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // editCommentTool
            // 
            this.editCommentTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editCommentTool.Image = ((System.Drawing.Image)(resources.GetObject("editCommentTool.Image")));
            this.editCommentTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCommentTool.Name = "editCommentTool";
            this.editCommentTool.Size = new System.Drawing.Size(23, 22);
            this.editCommentTool.Text = "Комментарий";
            this.editCommentTool.Click += new System.EventHandler(this.editCommentTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshListTool
            // 
            this.refreshListTool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshListTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshListTool.Image = ((System.Drawing.Image)(resources.GetObject("refreshListTool.Image")));
            this.refreshListTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshListTool.Name = "refreshListTool";
            this.refreshListTool.Size = new System.Drawing.Size(23, 22);
            this.refreshListTool.Text = "Обновление";
            this.refreshListTool.Click += new System.EventHandler(this.refreshListTool_Click);
            // 
            // lblRefreshing
            // 
            this.lblRefreshing.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblRefreshing.Name = "lblRefreshing";
            this.lblRefreshing.Size = new System.Drawing.Size(78, 22);
            this.lblRefreshing.Text = "обновляем...";
            // 
            // printTool
            // 
            this.printTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printTool.Image = ((System.Drawing.Image)(resources.GetObject("printTool.Image")));
            this.printTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printTool.Name = "printTool";
            this.printTool.Size = new System.Drawing.Size(23, 22);
            this.printTool.Text = "Печать";
            this.printTool.Click += new System.EventHandler(this.printTool_Click);
            // 
            // findToolStrip
            // 
            this.findToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFind,
            this.tbox});
            this.findToolStrip.Location = new System.Drawing.Point(0, 21);
            this.findToolStrip.Name = "findToolStrip";
            this.findToolStrip.Size = new System.Drawing.Size(374, 25);
            this.findToolStrip.TabIndex = 2;
            this.findToolStrip.Text = "toolStrip1";
            // 
            // lblFind
            // 
            this.lblFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblFind.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(0, 22);
            this.lblFind.Text = "Найти пропуск";
            // 
            // tbox
            // 
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(150, 25);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 488);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(374, 34);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Сменить пароль";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // cboxUnit
            // 
            this.cboxUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxUnit.FormattingEnabled = true;
            this.cboxUnit.Location = new System.Drawing.Point(0, 0);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(374, 21);
            this.cboxUnit.TabIndex = 0;
            this.cboxUnit.SelectedValueChanged += new System.EventHandler(this.cboxUnit_SelectedValueChanged);
            // 
            // pnlData
            // 
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(374, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(558, 522);
            this.pnlData.TabIndex = 1;
            this.pnlData.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlData_ControlRemoved);
            // 
            // bckRefreshing
            // 
            this.bckRefreshing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckRefreshing_DoWork);
            this.bckRefreshing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckRefreshing_RunWorkerCompleted);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refrefhTimer_Tick);
            // 
            // bckLoadDocument
            // 
            this.bckLoadDocument.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckLoadDocument_DoWork);
            this.bckLoadDocument.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckLoadDocument_RunWorkerCompleted);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Материальные пропуска";
            this.notifyIcon.Visible = true;
            // 
            // notifyTimer
            // 
            this.notifyTimer.Interval = 500;
            this.notifyTimer.Tick += new System.EventHandler(this.notifyTimer_Tick);
            // 
            // ColumnDocNumber
            // 
            this.ColumnDocNumber.DataPropertyName = "DocNumber";
            this.ColumnDocNumber.HeaderText = "№ докум.";
            this.ColumnDocNumber.Name = "ColumnDocNumber";
            this.ColumnDocNumber.ReadOnly = true;
            this.ColumnDocNumber.Width = 75;
            // 
            // ColumnDocDate
            // 
            this.ColumnDocDate.DataPropertyName = "DocDate";
            this.ColumnDocDate.HeaderText = "Дата";
            this.ColumnDocDate.Name = "ColumnDocDate";
            this.ColumnDocDate.ReadOnly = true;
            this.ColumnDocDate.Width = 75;
            // 
            // ColumnCreator
            // 
            this.ColumnCreator.DataPropertyName = "CreateFlagImage";
            this.ColumnCreator.HeaderText = "клад.";
            this.ColumnCreator.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnCreator.Name = "ColumnCreator";
            this.ColumnCreator.ReadOnly = true;
            this.ColumnCreator.Width = 40;
            // 
            // ColumnSigner
            // 
            this.ColumnSigner.DataPropertyName = "SignedFlagImage";
            this.ColumnSigner.HeaderText = "служ. без-ти";
            this.ColumnSigner.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnSigner.Name = "ColumnSigner";
            this.ColumnSigner.ReadOnly = true;
            this.ColumnSigner.Width = 40;
            // 
            // ColumnEntry
            // 
            this.ColumnEntry.DataPropertyName = "EntryFlagImage";
            this.ColumnEntry.HeaderText = "выезд";
            this.ColumnEntry.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEntry.Name = "ColumnEntry";
            this.ColumnEntry.ReadOnly = true;
            this.ColumnEntry.Width = 40;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 522);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlLeft);
            this.Name = "StartForm";
            this.Text = "Управление материальными пропусками";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentList)).EndInit();
            this.documentToolStrip.ResumeLayout(false);
            this.documentToolStrip.PerformLayout();
            this.findToolStrip.ResumeLayout(false);
            this.findToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.ToolStrip findToolStrip;
        private System.Windows.Forms.ToolStripLabel lblFind;
        private System.Windows.Forms.ToolStrip documentToolStrip;
        private System.Windows.Forms.ToolStripTextBox tbox;
        private System.Windows.Forms.ToolStripButton addDocTool;
        private System.Windows.Forms.BindingSource bsDocumentList;
        private System.Windows.Forms.ToolStripButton editDocTool;
        private System.Windows.Forms.ToolStripButton deleteDocTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshListTool;
        private System.Windows.Forms.ToolStripLabel lblRefreshing;
        private System.ComponentModel.BackgroundWorker bckRefreshing;
        private System.Windows.Forms.DataGridView dgvDocumentList;
        private System.Windows.Forms.Timer refreshTimer;
        private System.ComponentModel.BackgroundWorker bckLoadDocument;
        private System.Windows.Forms.ToolStripButton printTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton editCommentTool;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer notifyTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocDate;
        private System.Windows.Forms.DataGridViewImageColumn ColumnCreator;
        private System.Windows.Forms.DataGridViewImageColumn ColumnSigner;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEntry;
    }
}

