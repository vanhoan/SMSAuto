namespace SMSAuto
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvPort = new System.Windows.Forms.DataGridView();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Infor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRunning = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLoadPort = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSend = new System.Windows.Forms.GroupBox();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.btnDeleteSend = new System.Windows.Forms.Button();
            this.btnAddSend = new System.Windows.Forms.Button();
            this.dgvSend = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPortSend = new System.Windows.Forms.ComboBox();
            this.cbPortReceive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReceive = new System.Windows.Forms.GroupBox();
            this.btnClearRe = new System.Windows.Forms.Button();
            this.btnDeleteRe = new System.Windows.Forms.Button();
            this.btnAddReceive = new System.Windows.Forms.Button();
            this.dgvReceive = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLastConfig = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAddPort = new System.Windows.Forms.CheckBox();
            this.btnStopLoadPort = new System.Windows.Forms.Button();
            this.lblTotalActive = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRunningActive = new System.Windows.Forms.Label();
            this.lblStatusActive = new System.Windows.Forms.Label();
            this.btnLoadPortActive = new System.Windows.Forms.Button();
            this.chkCheckAll = new System.Windows.Forms.CheckBox();
            this.btnStopActive = new System.Windows.Forms.Button();
            this.btnStartActive = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassActive = new System.Windows.Forms.TextBox();
            this.lblTotalPortActive = new System.Windows.Forms.Label();
            this.dgvPortActive = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Process = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetSMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangePass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InforActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSend)).BeginInit();
            this.gbReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceive)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortActive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(279, 480);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvPort
            // 
            this.dgvPort.AllowUserToAddRows = false;
            this.dgvPort.AllowUserToDeleteRows = false;
            this.dgvPort.AllowUserToResizeColumns = false;
            this.dgvPort.AllowUserToResizeRows = false;
            this.dgvPort.BackgroundColor = System.Drawing.Color.White;
            this.dgvPort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Port,
            this.Status,
            this.PhoneTransfer,
            this.Infor});
            this.dgvPort.Location = new System.Drawing.Point(5, 27);
            this.dgvPort.Name = "dgvPort";
            this.dgvPort.RowHeadersVisible = false;
            this.dgvPort.Size = new System.Drawing.Size(678, 179);
            this.dgvPort.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 60;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // PhoneTransfer
            // 
            this.PhoneTransfer.HeaderText = "Phone";
            this.PhoneTransfer.Name = "PhoneTransfer";
            this.PhoneTransfer.ReadOnly = true;
            // 
            // Infor
            // 
            this.Infor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Infor.HeaderText = "Infor";
            this.Infor.Name = "Infor";
            this.Infor.ReadOnly = true;
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Location = new System.Drawing.Point(10, 462);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(56, 13);
            this.lblRunning.TabIndex = 2;
            this.lblRunning.Text = "Running : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 489);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // btnLoadPort
            // 
            this.btnLoadPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPort.Location = new System.Drawing.Point(93, 206);
            this.btnLoadPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadPort.Name = "btnLoadPort";
            this.btnLoadPort.Size = new System.Drawing.Size(66, 26);
            this.btnLoadPort.TabIndex = 4;
            this.btnLoadPort.Text = "Load Port";
            this.btnLoadPort.UseVisualStyleBackColor = true;
            this.btnLoadPort.Click += new System.EventHandler(this.btnLoadPort_Click);
            // 
            // picLoading
            // 
            this.picLoading.Location = new System.Drawing.Point(618, 0);
            this.picLoading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(75, 23);
            this.picLoading.TabIndex = 6;
            this.picLoading.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gbSend
            // 
            this.gbSend.Controls.Add(this.btnClearSend);
            this.gbSend.Controls.Add(this.btnDeleteSend);
            this.gbSend.Controls.Add(this.btnAddSend);
            this.gbSend.Controls.Add(this.dgvSend);
            this.gbSend.Controls.Add(this.label2);
            this.gbSend.Controls.Add(this.cbPortSend);
            this.gbSend.Location = new System.Drawing.Point(5, 286);
            this.gbSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSend.Name = "gbSend";
            this.gbSend.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSend.Size = new System.Drawing.Size(338, 173);
            this.gbSend.TabIndex = 8;
            this.gbSend.TabStop = false;
            this.gbSend.Text = "Send Money";
            // 
            // btnClearSend
            // 
            this.btnClearSend.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSend.Image")));
            this.btnClearSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearSend.Location = new System.Drawing.Point(313, 148);
            this.btnClearSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(21, 21);
            this.btnClearSend.TabIndex = 7;
            this.btnClearSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // btnDeleteSend
            // 
            this.btnDeleteSend.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSend.Image")));
            this.btnDeleteSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSend.Location = new System.Drawing.Point(313, 125);
            this.btnDeleteSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteSend.Name = "btnDeleteSend";
            this.btnDeleteSend.Size = new System.Drawing.Size(21, 21);
            this.btnDeleteSend.TabIndex = 6;
            this.btnDeleteSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSend.UseVisualStyleBackColor = true;
            this.btnDeleteSend.Click += new System.EventHandler(this.btnDeleteSend_Click);
            // 
            // btnAddSend
            // 
            this.btnAddSend.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSend.Image")));
            this.btnAddSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSend.Location = new System.Drawing.Point(146, 24);
            this.btnAddSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSend.Name = "btnAddSend";
            this.btnAddSend.Size = new System.Drawing.Size(57, 20);
            this.btnAddSend.TabIndex = 5;
            this.btnAddSend.Text = "Add";
            this.btnAddSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSend.UseVisualStyleBackColor = true;
            this.btnAddSend.Click += new System.EventHandler(this.btnAddSend_Click);
            // 
            // dgvSend
            // 
            this.dgvSend.AllowUserToAddRows = false;
            this.dgvSend.BackgroundColor = System.Drawing.Color.White;
            this.dgvSend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.PortSend,
            this.Phone,
            this.Money,
            this.StatusSend});
            this.dgvSend.Location = new System.Drawing.Point(7, 51);
            this.dgvSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSend.Name = "dgvSend";
            this.dgvSend.RowHeadersVisible = false;
            this.dgvSend.RowTemplate.Height = 24;
            this.dgvSend.Size = new System.Drawing.Size(302, 117);
            this.dgvSend.TabIndex = 4;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // PortSend
            // 
            this.PortSend.HeaderText = "Port";
            this.PortSend.Name = "PortSend";
            this.PortSend.ReadOnly = true;
            this.PortSend.Width = 60;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Money
            // 
            this.Money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Money.HeaderText = "Money";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            // 
            // StatusSend
            // 
            this.StatusSend.HeaderText = "Status";
            this.StatusSend.Name = "StatusSend";
            this.StatusSend.ReadOnly = true;
            this.StatusSend.Width = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port : ";
            // 
            // cbPortSend
            // 
            this.cbPortSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortSend.FormattingEnabled = true;
            this.cbPortSend.Location = new System.Drawing.Point(51, 24);
            this.cbPortSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPortSend.Name = "cbPortSend";
            this.cbPortSend.Size = new System.Drawing.Size(92, 21);
            this.cbPortSend.TabIndex = 1;
            // 
            // cbPortReceive
            // 
            this.cbPortReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortReceive.FormattingEnabled = true;
            this.cbPortReceive.Location = new System.Drawing.Point(52, 22);
            this.cbPortReceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPortReceive.Name = "cbPortReceive";
            this.cbPortReceive.Size = new System.Drawing.Size(92, 21);
            this.cbPortReceive.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port : ";
            // 
            // gbReceive
            // 
            this.gbReceive.Controls.Add(this.btnClearRe);
            this.gbReceive.Controls.Add(this.btnDeleteRe);
            this.gbReceive.Controls.Add(this.btnAddReceive);
            this.gbReceive.Controls.Add(this.dgvReceive);
            this.gbReceive.Controls.Add(this.label1);
            this.gbReceive.Controls.Add(this.cbPortReceive);
            this.gbReceive.Location = new System.Drawing.Point(348, 287);
            this.gbReceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReceive.Name = "gbReceive";
            this.gbReceive.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReceive.Size = new System.Drawing.Size(335, 172);
            this.gbReceive.TabIndex = 3;
            this.gbReceive.TabStop = false;
            this.gbReceive.Text = "Receive Money";
            // 
            // btnClearRe
            // 
            this.btnClearRe.Image = ((System.Drawing.Image)(resources.GetObject("btnClearRe.Image")));
            this.btnClearRe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearRe.Location = new System.Drawing.Point(311, 145);
            this.btnClearRe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearRe.Name = "btnClearRe";
            this.btnClearRe.Size = new System.Drawing.Size(22, 21);
            this.btnClearRe.TabIndex = 8;
            this.btnClearRe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearRe.UseVisualStyleBackColor = true;
            this.btnClearRe.Click += new System.EventHandler(this.btnClearRe_Click);
            // 
            // btnDeleteRe
            // 
            this.btnDeleteRe.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRe.Image")));
            this.btnDeleteRe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRe.Location = new System.Drawing.Point(311, 124);
            this.btnDeleteRe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRe.Name = "btnDeleteRe";
            this.btnDeleteRe.Size = new System.Drawing.Size(22, 21);
            this.btnDeleteRe.TabIndex = 7;
            this.btnDeleteRe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRe.UseVisualStyleBackColor = true;
            this.btnDeleteRe.Click += new System.EventHandler(this.btnDeleteRe_Click);
            // 
            // btnAddReceive
            // 
            this.btnAddReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReceive.Image")));
            this.btnAddReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReceive.Location = new System.Drawing.Point(147, 21);
            this.btnAddReceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddReceive.Name = "btnAddReceive";
            this.btnAddReceive.Size = new System.Drawing.Size(57, 22);
            this.btnAddReceive.TabIndex = 6;
            this.btnAddReceive.Text = "Add";
            this.btnAddReceive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddReceive.UseVisualStyleBackColor = true;
            this.btnAddReceive.Click += new System.EventHandler(this.btnAddReceive_Click);
            // 
            // dgvReceive
            // 
            this.dgvReceive.AllowUserToAddRows = false;
            this.dgvReceive.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PortReceive,
            this.PhoneRe,
            this.MoneyRe});
            this.dgvReceive.Location = new System.Drawing.Point(7, 49);
            this.dgvReceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReceive.Name = "dgvReceive";
            this.dgvReceive.RowHeadersVisible = false;
            this.dgvReceive.RowTemplate.Height = 24;
            this.dgvReceive.Size = new System.Drawing.Size(300, 117);
            this.dgvReceive.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // PortReceive
            // 
            this.PortReceive.HeaderText = "Port";
            this.PortReceive.Name = "PortReceive";
            this.PortReceive.ReadOnly = true;
            this.PortReceive.Width = 60;
            // 
            // PhoneRe
            // 
            this.PhoneRe.HeaderText = "Phone";
            this.PhoneRe.Name = "PhoneRe";
            // 
            // MoneyRe
            // 
            this.MoneyRe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoneyRe.HeaderText = "Money";
            this.MoneyRe.Name = "MoneyRe";
            this.MoneyRe.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLastConfig);
            this.groupBox3.Controls.Add(this.rbNone);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Location = new System.Drawing.Point(4, 235);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(678, 50);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer Money";
            // 
            // rbLastConfig
            // 
            this.rbLastConfig.AutoSize = true;
            this.rbLastConfig.Location = new System.Drawing.Point(593, 17);
            this.rbLastConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLastConfig.Name = "rbLastConfig";
            this.rbLastConfig.Size = new System.Drawing.Size(77, 17);
            this.rbLastConfig.TabIndex = 9;
            this.rbLastConfig.Text = "Last config";
            this.rbLastConfig.UseVisualStyleBackColor = true;
            this.rbLastConfig.CheckedChanged += new System.EventHandler(this.rbLastConfig_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(535, 17);
            this.rbNone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 8;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(74, 23);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(76, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(355, 480);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 527);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkAddPort);
            this.tabPage1.Controls.Add(this.btnStopLoadPort);
            this.tabPage1.Controls.Add(this.lblTotalActive);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.dgvPort);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.lblRunning);
            this.tabPage1.Controls.Add(this.gbReceive);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.gbSend);
            this.tabPage1.Controls.Add(this.btnLoadPort);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(685, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transfer Money";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkAddPort
            // 
            this.chkAddPort.AutoSize = true;
            this.chkAddPort.Checked = true;
            this.chkAddPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddPort.Location = new System.Drawing.Point(193, 210);
            this.chkAddPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAddPort.Name = "chkAddPort";
            this.chkAddPort.Size = new System.Drawing.Size(109, 17);
            this.chkAddPort.TabIndex = 14;
            this.chkAddPort.Text = "Add Port Transfer";
            this.chkAddPort.UseVisualStyleBackColor = true;
            // 
            // btnStopLoadPort
            // 
            this.btnStopLoadPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopLoadPort.Location = new System.Drawing.Point(93, 206);
            this.btnStopLoadPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStopLoadPort.Name = "btnStopLoadPort";
            this.btnStopLoadPort.Size = new System.Drawing.Size(46, 26);
            this.btnStopLoadPort.TabIndex = 13;
            this.btnStopLoadPort.Text = "Stop";
            this.btnStopLoadPort.UseVisualStyleBackColor = true;
            this.btnStopLoadPort.Visible = false;
            this.btnStopLoadPort.Click += new System.EventHandler(this.btnStopLoadPort_Click);
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.Location = new System.Drawing.Point(8, 10);
            this.lblTotalActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(13, 13);
            this.lblTotalActive.TabIndex = 12;
            this.lblTotalActive.Text = "0";
            // 
            // btnConnect
            // 
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(5, 206);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(60, 24);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRunningActive);
            this.tabPage2.Controls.Add(this.lblStatusActive);
            this.tabPage2.Controls.Add(this.btnLoadPortActive);
            this.tabPage2.Controls.Add(this.chkCheckAll);
            this.tabPage2.Controls.Add(this.btnStopActive);
            this.tabPage2.Controls.Add(this.btnStartActive);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lblTotalPortActive);
            this.tabPage2.Controls.Add(this.dgvPortActive);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(685, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Active";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRunningActive
            // 
            this.lblRunningActive.AutoSize = true;
            this.lblRunningActive.Location = new System.Drawing.Point(8, 366);
            this.lblRunningActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRunningActive.Name = "lblRunningActive";
            this.lblRunningActive.Size = new System.Drawing.Size(56, 13);
            this.lblRunningActive.TabIndex = 21;
            this.lblRunningActive.Text = "Running : ";
            // 
            // lblStatusActive
            // 
            this.lblStatusActive.AutoSize = true;
            this.lblStatusActive.Location = new System.Drawing.Point(5, 362);
            this.lblStatusActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusActive.Name = "lblStatusActive";
            this.lblStatusActive.Size = new System.Drawing.Size(0, 13);
            this.lblStatusActive.TabIndex = 20;
            // 
            // btnLoadPortActive
            // 
            this.btnLoadPortActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPortActive.Location = new System.Drawing.Point(615, 362);
            this.btnLoadPortActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadPortActive.Name = "btnLoadPortActive";
            this.btnLoadPortActive.Size = new System.Drawing.Size(66, 26);
            this.btnLoadPortActive.TabIndex = 19;
            this.btnLoadPortActive.Text = "Load Port";
            this.btnLoadPortActive.UseVisualStyleBackColor = true;
            this.btnLoadPortActive.Click += new System.EventHandler(this.btnLoadPortActive_Click);
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.Location = new System.Drawing.Point(7, 12);
            this.chkCheckAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Size = new System.Drawing.Size(37, 17);
            this.chkCheckAll.TabIndex = 18;
            this.chkCheckAll.Text = "All";
            this.chkCheckAll.UseVisualStyleBackColor = true;
            this.chkCheckAll.CheckedChanged += new System.EventHandler(this.chkCheckAll_CheckedChanged);
            // 
            // btnStopActive
            // 
            this.btnStopActive.Image = ((System.Drawing.Image)(resources.GetObject("btnStopActive.Image")));
            this.btnStopActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopActive.Location = new System.Drawing.Point(347, 466);
            this.btnStopActive.Name = "btnStopActive";
            this.btnStopActive.Size = new System.Drawing.Size(64, 23);
            this.btnStopActive.TabIndex = 17;
            this.btnStopActive.Text = "Stop";
            this.btnStopActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopActive.UseVisualStyleBackColor = true;
            this.btnStopActive.Click += new System.EventHandler(this.btnStopActive_Click);
            // 
            // btnStartActive
            // 
            this.btnStartActive.Image = ((System.Drawing.Image)(resources.GetObject("btnStartActive.Image")));
            this.btnStartActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartActive.Location = new System.Drawing.Point(272, 466);
            this.btnStartActive.Name = "btnStartActive";
            this.btnStartActive.Size = new System.Drawing.Size(64, 23);
            this.btnStartActive.TabIndex = 16;
            this.btnStartActive.Text = "Start";
            this.btnStartActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartActive.UseVisualStyleBackColor = true;
            this.btnStartActive.Click += new System.EventHandler(this.btnStartActive_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassActive);
            this.groupBox1.Location = new System.Drawing.Point(4, 393);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(678, 50);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password : ";
            // 
            // txtPassActive
            // 
            this.txtPassActive.Location = new System.Drawing.Point(74, 23);
            this.txtPassActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassActive.Name = "txtPassActive";
            this.txtPassActive.Size = new System.Drawing.Size(76, 20);
            this.txtPassActive.TabIndex = 6;
            // 
            // lblTotalPortActive
            // 
            this.lblTotalPortActive.AutoSize = true;
            this.lblTotalPortActive.Location = new System.Drawing.Point(668, 13);
            this.lblTotalPortActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPortActive.Name = "lblTotalPortActive";
            this.lblTotalPortActive.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPortActive.TabIndex = 14;
            this.lblTotalPortActive.Text = "0";
            // 
            // dgvPortActive
            // 
            this.dgvPortActive.AllowUserToAddRows = false;
            this.dgvPortActive.AllowUserToDeleteRows = false;
            this.dgvPortActive.AllowUserToResizeColumns = false;
            this.dgvPortActive.AllowUserToResizeRows = false;
            this.dgvPortActive.BackgroundColor = System.Drawing.Color.White;
            this.dgvPortActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPortActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Actived,
            this.GetSMS,
            this.ChangePass,
            this.InforActive});
            this.dgvPortActive.Location = new System.Drawing.Point(4, 30);
            this.dgvPortActive.Name = "dgvPortActive";
            this.dgvPortActive.RowHeadersVisible = false;
            this.dgvPortActive.Size = new System.Drawing.Size(678, 330);
            this.dgvPortActive.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 568);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(690, 19);
            this.progressBar1.TabIndex = 12;
            // 
            // Process
            // 
            this.Process.HeaderText = "";
            this.Process.Name = "Process";
            this.Process.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Port";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Actived
            // 
            this.Actived.HeaderText = "Actived";
            this.Actived.Name = "Actived";
            this.Actived.ReadOnly = true;
            this.Actived.Width = 80;
            // 
            // GetSMS
            // 
            this.GetSMS.HeaderText = "Get Password";
            this.GetSMS.Name = "GetSMS";
            this.GetSMS.ReadOnly = true;
            this.GetSMS.Width = 120;
            // 
            // ChangePass
            // 
            this.ChangePass.HeaderText = "Change Password";
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.ReadOnly = true;
            this.ChangePass.Width = 120;
            // 
            // InforActive
            // 
            this.InforActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InforActive.HeaderText = "Infor";
            this.InforActive.Name = "InforActive";
            this.InforActive.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 587);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Auto Transfer Money";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSend.ResumeLayout(false);
            this.gbSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSend)).EndInit();
            this.gbReceive.ResumeLayout(false);
            this.gbReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceive)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvPort;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLoadPort;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPortSend;
        private System.Windows.Forms.ComboBox cbPortReceive;
        private System.Windows.Forms.GroupBox gbReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSend;
        private System.Windows.Forms.DataGridView dgvReceive;
        private System.Windows.Forms.Button btnDeleteSend;
        private System.Windows.Forms.Button btnAddSend;
        private System.Windows.Forms.Button btnAddReceive;
        private System.Windows.Forms.Button btnDeleteRe;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.Button btnClearRe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Infor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusSend;
        private System.Windows.Forms.RadioButton rbLastConfig;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblTotalActive;
        private System.Windows.Forms.Button btnStopLoadPort;
        private System.Windows.Forms.CheckBox chkAddPort;
        private System.Windows.Forms.Label lblTotalPortActive;
        private System.Windows.Forms.DataGridView dgvPortActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassActive;
        private System.Windows.Forms.Button btnStopActive;
        private System.Windows.Forms.Button btnStartActive;
        private System.Windows.Forms.CheckBox chkCheckAll;
        private System.Windows.Forms.Button btnLoadPortActive;
        private System.Windows.Forms.Label lblStatusActive;
        private System.Windows.Forms.Label lblRunningActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actived;
        private System.Windows.Forms.DataGridViewTextBoxColumn GetSMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangePass;
        private System.Windows.Forms.DataGridViewTextBoxColumn InforActive;
    }
}

