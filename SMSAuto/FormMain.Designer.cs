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
            this.Infor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPortSelect = new System.Windows.Forms.Label();
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
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmout = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSend)).BeginInit();
            this.gbReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceive)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(371, 576);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvPort
            // 
            this.dgvPort.AllowUserToAddRows = false;
            this.dgvPort.AllowUserToDeleteRows = false;
            this.dgvPort.AllowUserToResizeColumns = false;
            this.dgvPort.AllowUserToResizeRows = false;
            this.dgvPort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Port,
            this.Status,
            this.Infor});
            this.dgvPort.Location = new System.Drawing.Point(13, 48);
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
            // Infor
            // 
            this.Infor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Infor.HeaderText = "Infor";
            this.Infor.Name = "Infor";
            this.Infor.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 554);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 17);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label1";
            // 
            // lblPortSelect
            // 
            this.lblPortSelect.AutoSize = true;
            this.lblPortSelect.Location = new System.Drawing.Point(20, 587);
            this.lblPortSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortSelect.Name = "lblPortSelect";
            this.lblPortSelect.Size = new System.Drawing.Size(46, 17);
            this.lblPortSelect.TabIndex = 3;
            this.lblPortSelect.Text = "label1";
            // 
            // btnLoadPort
            // 
            this.btnLoadPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPort.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPort.Image")));
            this.btnLoadPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPort.Location = new System.Drawing.Point(791, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
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
            this.gbSend.Location = new System.Drawing.Point(13, 276);
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
            this.dgvSend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.PortSend,
            this.Phone,
            this.Money});
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
            this.No.Width = 50;
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
            this.gbReceive.Location = new System.Drawing.Point(470, 277);
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
            this.dataGridViewTextBoxColumn1.Width = 50;
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
            this.groupBox3.Controls.Add(this.cbCurrency);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAmout);
            this.groupBox3.Location = new System.Drawing.Point(13, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 61);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer Money";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(185, 24);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(61, 24);
            this.cbCurrency.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amout : ";
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(79, 24);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(100, 22);
            this.txtAmout.TabIndex = 0;
            this.txtAmout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmout_KeyPress);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(479, 576);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 613);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbReceive);
            this.Controls.Add(this.gbSend);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.btnLoadPort);
            this.Controls.Add(this.lblPortSelect);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvPort);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvPort;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPortSelect;
        private System.Windows.Forms.Button btnLoadPort;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Infor;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmout;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyRe;
    }
}

