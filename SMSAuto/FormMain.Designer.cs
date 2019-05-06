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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblTotalActive = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(372, 557);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 28);
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
            this.dgvPort.Location = new System.Drawing.Point(7, 29);
            this.dgvPort.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPort.Name = "dgvPort";
            this.dgvPort.RowHeadersVisible = false;
            this.dgvPort.Size = new System.Drawing.Size(904, 224);
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
            this.lblRunning.Location = new System.Drawing.Point(14, 535);
            this.lblRunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(73, 17);
            this.lblRunning.TabIndex = 2;
            this.lblRunning.Text = "Running : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 568);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 3;
            // 
            // btnLoadPort
            // 
            this.btnLoadPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPort.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPort.Image")));
            this.btnLoadPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPort.Location = new System.Drawing.Point(797, 3);
            this.btnLoadPort.Name = "btnLoadPort";
            this.btnLoadPort.Size = new System.Drawing.Size(113, 23);
            this.btnLoadPort.TabIndex = 4;
            this.btnLoadPort.Text = "Load Port";
            this.btnLoadPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPort.UseVisualStyleBackColor = true;
            this.btnLoadPort.Click += new System.EventHandler(this.btnLoadPort_Click);
            // 
            // picLoading
            // 
            this.picLoading.Location = new System.Drawing.Point(322, 0);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(100, 28);
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
            this.menuStrip1.Size = new System.Drawing.Size(930, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
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
            this.gbSend.Location = new System.Drawing.Point(7, 318);
            this.gbSend.Name = "gbSend";
            this.gbSend.Size = new System.Drawing.Size(451, 213);
            this.gbSend.TabIndex = 8;
            this.gbSend.TabStop = false;
            this.gbSend.Text = "Send Money";
            // 
            // btnClearSend
            // 
            this.btnClearSend.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSend.Image")));
            this.btnClearSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearSend.Location = new System.Drawing.Point(417, 182);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(28, 26);
            this.btnClearSend.TabIndex = 7;
            this.btnClearSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // btnDeleteSend
            // 
            this.btnDeleteSend.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSend.Image")));
            this.btnDeleteSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSend.Location = new System.Drawing.Point(417, 154);
            this.btnDeleteSend.Name = "btnDeleteSend";
            this.btnDeleteSend.Size = new System.Drawing.Size(28, 26);
            this.btnDeleteSend.TabIndex = 6;
            this.btnDeleteSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSend.UseVisualStyleBackColor = true;
            this.btnDeleteSend.Click += new System.EventHandler(this.btnDeleteSend_Click);
            // 
            // btnAddSend
            // 
            this.btnAddSend.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSend.Image")));
            this.btnAddSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSend.Location = new System.Drawing.Point(195, 29);
            this.btnAddSend.Name = "btnAddSend";
            this.btnAddSend.Size = new System.Drawing.Size(76, 25);
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
            this.dgvSend.Location = new System.Drawing.Point(9, 63);
            this.dgvSend.Name = "dgvSend";
            this.dgvSend.RowHeadersVisible = false;
            this.dgvSend.RowTemplate.Height = 24;
            this.dgvSend.Size = new System.Drawing.Size(402, 144);
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
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port : ";
            // 
            // cbPortSend
            // 
            this.cbPortSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortSend.FormattingEnabled = true;
            this.cbPortSend.Location = new System.Drawing.Point(68, 30);
            this.cbPortSend.Name = "cbPortSend";
            this.cbPortSend.Size = new System.Drawing.Size(121, 24);
            this.cbPortSend.TabIndex = 1;
            // 
            // cbPortReceive
            // 
            this.cbPortReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortReceive.FormattingEnabled = true;
            this.cbPortReceive.Location = new System.Drawing.Point(69, 27);
            this.cbPortReceive.Name = "cbPortReceive";
            this.cbPortReceive.Size = new System.Drawing.Size(121, 24);
            this.cbPortReceive.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
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
            this.gbReceive.Location = new System.Drawing.Point(464, 319);
            this.gbReceive.Name = "gbReceive";
            this.gbReceive.Size = new System.Drawing.Size(447, 212);
            this.gbReceive.TabIndex = 3;
            this.gbReceive.TabStop = false;
            this.gbReceive.Text = "Receive Money";
            // 
            // btnClearRe
            // 
            this.btnClearRe.Image = ((System.Drawing.Image)(resources.GetObject("btnClearRe.Image")));
            this.btnClearRe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearRe.Location = new System.Drawing.Point(415, 179);
            this.btnClearRe.Name = "btnClearRe";
            this.btnClearRe.Size = new System.Drawing.Size(29, 26);
            this.btnClearRe.TabIndex = 8;
            this.btnClearRe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearRe.UseVisualStyleBackColor = true;
            this.btnClearRe.Click += new System.EventHandler(this.btnClearRe_Click);
            // 
            // btnDeleteRe
            // 
            this.btnDeleteRe.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRe.Image")));
            this.btnDeleteRe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRe.Location = new System.Drawing.Point(415, 153);
            this.btnDeleteRe.Name = "btnDeleteRe";
            this.btnDeleteRe.Size = new System.Drawing.Size(29, 26);
            this.btnDeleteRe.TabIndex = 7;
            this.btnDeleteRe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRe.UseVisualStyleBackColor = true;
            this.btnDeleteRe.Click += new System.EventHandler(this.btnDeleteRe_Click);
            // 
            // btnAddReceive
            // 
            this.btnAddReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReceive.Image")));
            this.btnAddReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReceive.Location = new System.Drawing.Point(196, 26);
            this.btnAddReceive.Name = "btnAddReceive";
            this.btnAddReceive.Size = new System.Drawing.Size(76, 25);
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
            this.dgvReceive.Location = new System.Drawing.Point(9, 60);
            this.dgvReceive.Name = "dgvReceive";
            this.dgvReceive.RowHeadersVisible = false;
            this.dgvReceive.RowTemplate.Height = 24;
            this.dgvReceive.Size = new System.Drawing.Size(400, 144);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 61);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer Money";
            // 
            // rbLastConfig
            // 
            this.rbLastConfig.AutoSize = true;
            this.rbLastConfig.Location = new System.Drawing.Point(791, 21);
            this.rbLastConfig.Name = "rbLastConfig";
            this.rbLastConfig.Size = new System.Drawing.Size(98, 21);
            this.rbLastConfig.TabIndex = 9;
            this.rbLastConfig.Text = "Last config";
            this.rbLastConfig.UseVisualStyleBackColor = true;
            this.rbLastConfig.CheckedChanged += new System.EventHandler(this.rbLastConfig_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(713, 21);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(63, 21);
            this.rbNone.TabIndex = 8;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 28);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(473, 557);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 28);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 621);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transfer Money";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Active";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 668);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(920, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(671, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.Location = new System.Drawing.Point(7, 7);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(16, 17);
            this.lblTotalActive.TabIndex = 12;
            this.lblTotalActive.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 692);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

