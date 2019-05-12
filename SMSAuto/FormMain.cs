using SMSAuto.Action;
using SMSAuto.Common;
using SMSAuto.Custom;
using SMSAuto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SMSAuto
{
    public partial class FormMain : Form
    {
        bool check = true;
        private Active active = new Active();
        List<ComPort> listPort = new List<ComPort>();

        List<ComPort> listPortProcess = new List<ComPort>();
        List<ComPort> listPortProcessSuccess = new List<ComPort>();
        List<ComPort> listPortActive = new List<ComPort>();
        List<ComPort> listPortSend = new List<ComPort>();
        List<ComPort> listPortReveice = new List<ComPort>();
        List<ComPort> listPortActiveProcess = new List<ComPort>();

        private int i = 0;
        private int count = 0;
        private bool FLAG_PROCESS = true;
        private string PASSWORD = "";
        private string PASSWORD_ACTIVE = "";
        private int LOOP = 3;
        private bool FLAG_ADDPORT = true;
        private BackgroundWorker backgWorker = new BackgroundWorker();
        private BackgroundWorker backgWorkerActive = new BackgroundWorker();

        public FormMain()
        {
            InitializeComponent();
            backgWorker.WorkerReportsProgress = true;
            backgWorker.WorkerSupportsCancellation = true;
            backgWorker.DoWork += new DoWorkEventHandler(backgWorker_DoWork);
            backgWorker.ProgressChanged += new ProgressChangedEventHandler(backgWorker_ProgressChanged);
            backgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgWorker_RunWorkerCompleted);

            backgWorkerActive.WorkerReportsProgress = true;
            backgWorkerActive.WorkerSupportsCancellation = true;
            backgWorkerActive.DoWork += new DoWorkEventHandler(backgWorkerActive_DoWork);
            backgWorkerActive.ProgressChanged += new ProgressChangedEventHandler(backgWorkerActive_ProgressChanged);
            backgWorkerActive.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgWorkerActive_RunWorkerCompleted);

            ProcessLoadStart();
        }

        #region Load

        private void ProcessLoadStart()
        {
            SetImageLoading();
            Thread t = new Thread(
            () =>
            {
                try
                {
                    check = active.checkActive();
                    string loop = Utils.ReadFile(Constant.PATH_FILE_LOOP);

                    if (!string.IsNullOrEmpty(loop))
                    {
                        LOOP = int.Parse(loop);
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    UpdateProcessLoadStart();
                }
            });
            t.Start();
        }
        private void SetImageLoading()
        {
            picLoading.Location = new System.Drawing.Point(0, 0);
            picLoading.Size = new System.Drawing.Size(this.Width, this.Height);
            picLoading.Image = Properties.Resources.loading_start;
            picLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            picLoading.BringToFront();
        }
        private void UpdateProcessLoadStart()
        {
            if (!check)
            {
                MessageBox.Show("Can't load tool", Constant.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            ChangeUI(() => picLoading.Hide());
            ChangeUI(() => this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog);
        }
        private void ChangeUI(System.Action action)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(action);
                }
                else
                {
                    action();
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion

        private void GetSerialPorts()
        {
            listPort = new List<ComPort>();
            string[] listPo = System.IO.Ports.SerialPort.GetPortNames();
            listPortActive = new List<ComPort>();
            if (listPo.Length > 0)
            {
                ChangeUI(() => gbSend.Enabled = false);
                ChangeUI(() => gbReceive.Enabled = false);
                ChangeUI(() => btnConnect.Enabled = false);
                ChangeUI(() => lblTotalActive.Text = listPortActive.Count.ToString());
                ChangeUI(() => btnLoadPort.Hide());
                ChangeUI(() => btnStopLoadPort.Show());
            }
            int index = 0;
            dgvPort.Rows.Clear();
            dgvSend.Rows.Clear();
            dgvReceive.Rows.Clear();
            foreach (string item in listPo)
            {           
                Thread t = new Thread(
                () =>
                {
                    try
                    {
                        if (Constant.FLAG_PROCESS_LOADPORT)
                        {
                            ComPort port = GetPortInfor(item);
                            AddRowToGridView(port);
                        }                       
                    }
                    catch (Exception)
                    {
                        
                    }
                    finally
                    {
                        index++;
                        if (index == listPo.Length-1)
                        {
                            ChangeUI(() => gbSend.Enabled = true);
                            ChangeUI(() => gbReceive.Enabled = true);
                            ChangeUI(() => btnLoadPort.Show());
                            ChangeUI(() => btnStopLoadPort.Hide());
                            SetDataComBoBox();
                            if (FLAG_ADDPORT)
                            {
                                foreach (ComPort port in listPort)
                                {
                                    if (port.Status.Equals(Constant.STATUS_OK))
                                    {
                                        if (port.Money >= 10)
                                        {
                                            AddRowToGridViewTransfer(port, dgvSend);
                                        }
                                        else
                                        {
                                            AddRowToGridViewTransfer(port, dgvReceive);
                                        }
                                    }

                                }
                            }
                        }
                        ChangeUI(() => lblTotalActive.Text = listPortActive.Count.ToString());
                    }
                });
                t.Start();
            }
        }
        private void GetSerialPortsActive()
        {
            listPort = new List<ComPort>();
            string[] listPo = System.IO.Ports.SerialPort.GetPortNames();
            listPortActive = new List<ComPort>();
            if (listPo.Length > 0)
            {
                ChangeUI(() => btnLoadPortActive.Enabled = false);
            }
            int index = 0;
            dgvPortActive.Rows.Clear();
            foreach (string item in listPo)
            {
                Thread t = new Thread(
                () =>
                {
                    try
                    {
                        ComPort port = CheckingConnect(item);
                        if (port.Status.Equals(Constant.STATUS_OK))
                        {
                            AddRowToGridViewActive(port,true);
                        }
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        index++;
                        if (index == listPo.Length - 1)
                        {
                            ChangeUI(() => btnLoadPortActive.Enabled = true);
                            SetDataComBoBox();
                        }
                        ChangeUI(() => lblTotalPortActive.Text = listPortActive.Count.ToString());
                    }
                });
                t.Start();
            }
        }
        private void SetDataComBoBox()
        {
            List<string> ListCurrency = new List<string>();
            ChangeUI(() => cbPortSend.Items.Clear());
            ChangeUI(() => cbPortReceive.Items.Clear());
            List<ComPort> listnew = listPort.OrderBy(x => x.Name).ToList();
            foreach (var port in listnew)
            {
                if (port.Status.Equals(Constant.STATUS_OK))
                {
                    ChangeUI(() => cbPortSend.Items.Add(new ComboBoxItem(port.Name, port.Name)));
                    ChangeUI(() => cbPortReceive.Items.Add(new ComboBoxItem(port.Name, port.Name)));
                }
            }
        }
        private ComPort GetPortInfor(string port)
        {
            ComPort c = new ComPort();
            c.Name = port;
            ATAction action = new ATAction();
            Utils.WriteFileLog("Check banalce " + port, port);
            string reponse = action.CheckBanlce(port);
            c.Status = Utils.GetStatus(reponse);
            Utils.WriteFileLog("Check banalce status : " + c.Status, port);
            int loop = 0;
            while (!c.Status.Equals(Constant.STATUS_OK))
            {
                if (loop == LOOP || !Constant.FLAG_PROCESS_LOADPORT)
                {
                    Utils.WriteFileLog("Check banalce status : " + c.Status, port);
                    return c;
                }
                reponse = action.CheckBanlce(port);
                Utils.WriteFileLog("Check banalce " + port, port);
                c.Status = Utils.GetStatus(reponse);
                Utils.WriteFileLog("Check banalce status : " + c.Status, port);
                loop++;
            }
            Utils.WriteFileLog("Get phone number ", port);
            c.Phone = Utils.GetPhone(reponse);
            if (c.Status.Equals(Constant.STATUS_OK) && string.IsNullOrEmpty(c.Phone))
            {
                loop = 0;
                while (string.IsNullOrEmpty(c.Phone))
                {
                    if (loop == LOOP || !Constant.FLAG_PROCESS_LOADPORT)
                    {
                        return c;
                    }
                    c.Phone = action.GetPhoneNumber(port);
                    loop++;
                }  
            }
            c.Currency = Utils.GetCurrency(reponse);
            c.Money = Utils.GetMoney(reponse);                       
            c.Description = Utils.GetDescription(reponse);
            listPort.Add(c);
            if (c.Status.Equals(Constant.STATUS_OK))
            {
                listPortActive.Add(c);
            }
            return c;
        }

        private ComPort CheckingConnect(string port)
        {
            ComPort c = new ComPort();
            c.Name = port;
            ATAction action = new ATAction();
            string reponse = action.CheckConnect(port);
            if (reponse.IndexOf("OK") >= 0)
            {
                c.Status = Constant.STATUS_OK;
            }
            else if (reponse.IndexOf("ERROR") >= 0)
            {
                c.Status = Constant.STATUS_ERROR;
            }
            else
            {
                c.Status = Constant.STATUS_TIMEOUT;
            }
            if (c.Status.Equals(Constant.STATUS_OK) && string.IsNullOrEmpty(c.Phone))
            {
                c.Phone = action.GetPhoneNumber(port);
            }
            //c.Currency = Utils.GetCurrency(reponse);
            //c.Money = Utils.GetMoney(reponse);
            if (!string.IsNullOrEmpty(reponse) && !string.IsNullOrEmpty(c.Phone))
            {
                reponse = reponse.Replace(c.Phone, "");
            }

            c.Description = Utils.GetDescription(reponse);
            listPort.Add(c);
            if (c.Status.Equals(Constant.STATUS_OK))
            {
                listPortActive.Add(c);
            }
            return c;
        }

        private void AddRowToGridView(ComPort gmail)
        {
            try
            {
                DataGridViewTextBoxCell userCell = new DataGridViewTextBoxCell();
                userCell.Value = gmail.Name;
                DataGridViewTextBoxCell userStatus = new DataGridViewTextBoxCell();
                userStatus.Value = gmail.Status;
                DataGridViewTextBoxCell userPhone = new DataGridViewTextBoxCell();
                userPhone.Value = gmail.Phone;
                DataGridViewTextBoxCell userInfor = new DataGridViewTextBoxCell();
                userInfor.Value = gmail.Description;

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Cells.AddRange(userCell, userStatus, userPhone, userInfor);
                if (gmail.Status.Equals(Constant.STATUS_OK))
                {
                    newRow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                ChangeUI(() => dgvPort.Rows.Add(newRow));
            }
            catch (Exception)
            {
                
            }
                
        }

        private void AddRowToGridViewActive(ComPort gmail, bool process)
        {
            try
            {
                DataGridViewCheckBoxCell processCell = new DataGridViewCheckBoxCell();
                processCell.Value = process;
                DataGridViewTextBoxCell userCell = new DataGridViewTextBoxCell();
                userCell.Value = gmail.Name;
                DataGridViewTextBoxCell userStatus = new DataGridViewTextBoxCell();
                userStatus.Value = gmail.Status;
                DataGridViewTextBoxCell userPhone = new DataGridViewTextBoxCell();
                userPhone.Value = gmail.Phone;
                DataGridViewTextBoxCell userActive = new DataGridViewTextBoxCell();
                userActive.Value = "";
                DataGridViewTextBoxCell cellGetPass = new DataGridViewTextBoxCell();
                cellGetPass.Value = "";
                DataGridViewTextBoxCell cellChangePass = new DataGridViewTextBoxCell();
                cellChangePass.Value = "";
                DataGridViewTextBoxCell cellInfo = new DataGridViewTextBoxCell();
                cellInfo.Value = "";

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Cells.AddRange(processCell,userCell, userStatus, userPhone, userActive, cellGetPass, cellChangePass, cellInfo);
                ChangeUI(() => dgvPortActive.Rows.Add(newRow));
            }
            catch (Exception)
            {
               
            }

        }
        private void AddRowToGridViewTransfer(ComPort port, DataGridView dgv)
        {
            try
            {
                int row = dgv.RowCount;
                DataGridViewTextBoxCell userRow = new DataGridViewTextBoxCell();
                userRow.Value = row + 1;
                DataGridViewTextBoxCell userCell = new DataGridViewTextBoxCell();
                userCell.Value = port.Name;
                DataGridViewTextBoxCell userPhone = new DataGridViewTextBoxCell();
                userPhone.Value = port.Phone;
                DataGridViewTextBoxCell userMoney = new DataGridViewTextBoxCell();
                userMoney.Value = port.Money;

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Cells.AddRange(userRow, userCell, userPhone, userMoney);

                ChangeUI(() => dgv.Rows.Add(newRow));
            }
            catch (Exception)
            {

            }
            
        }
        private ComPort GetPortFromList(string portName)
        {            
            foreach (var port in listPort)
            {
                if (portName.Equals(port.Name))
                {
                    return port;
                }
            }
            return new ComPort();          
        }
        private bool ValidateChoosePort(string portName)
        {
            foreach (DataGridViewRow row in dgvSend.Rows)
            {
                string cellPort = row.Cells[1].Value.ToString();
                if (cellPort.Equals(portName))
                {
                    return true;
                }
            }
            foreach (DataGridViewRow row in dgvReceive.Rows)
            {
                string cellPort = row.Cells[1].Value.ToString();
                if (cellPort.Equals(portName))
                {
                    return true;
                }
            }
            
            return false;
        }
        private void ReloadIndexDataGridView(DataGridView dgv, int rowindex)
        {
            try
            {
                for (int x = rowindex; x <= dgv.RowCount; x++)
                {
                    dgv[0, x].Value = x + 1;
                }
            }
            catch (Exception)
            {

            }           
        }
        private void ReloadStatusDataGridView(DataGridView dgv, int rowindex)
        {
            try
            {
                foreach(ComPort port in listPortProcessSuccess)
                {
                    if(port.Name.Equals(dgv[1, rowindex].Value))
                    {
                        dgv[4, rowindex].Value = "OK";
                        return;
                    }
                }
                dgv[4, rowindex].Value = "Error";
              
            }
            catch (Exception)
            {

            }
        }

        private void ReloadValueCellDataGridViewActive(DataGridView dgv, int rowindex, int cellindex, string value)
        {
            try
            {
                ChangeUI(()=> dgv[cellindex, rowindex].Value = value);
            }
            catch (Exception)
            {

            }
        }

        private void btnLoadPort_Click(object sender, EventArgs e)
        {
            FLAG_ADDPORT = chkAddPort.Checked;
            Constant.FLAG_PROCESS_LOADPORT = true;
            GetSerialPorts();
            if (FLAG_ADDPORT) {
                foreach (ComPort port in listPort)
                {
                    if (port.Status.Equals(Constant.STATUS_OK))
                    {
                        if (port.Money >= 10)
                        {
                            AddRowToGridViewTransfer(port, dgvSend);
                        }
                        else
                        {
                            AddRowToGridViewTransfer(port, dgvReceive);
                        }
                    }

                }
            }   
        }
        private void btnStopLoadPort_Click(object sender, EventArgs e)
        {
            Constant.FLAG_PROCESS_LOADPORT = false;
            ChangeUI(() => btnLoadPort.Show());
            ChangeUI(() => btnStopLoadPort.Hide());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            listPort = new List<ComPort>();
            string[] listPo = System.IO.Ports.SerialPort.GetPortNames();
            listPortActive = new List<ComPort>();
            if(listPo.Length > 0)
            {
                ChangeUI(() => btnLoadPort.Enabled = false);
                ChangeUI(() => gbSend.Enabled = false);
                ChangeUI(() => gbReceive.Enabled = false);
                ChangeUI(() => btnConnect.Enabled = false);
                ChangeUI(() => lblTotalActive.Text = listPortActive.Count.ToString());
            }

            int index = 0;
            dgvPort.Rows.Clear();
            dgvSend.Rows.Clear();
            dgvReceive.Rows.Clear();
            foreach (string item in listPo)
            {
                Thread t = new Thread(
                () =>
                {
                    try
                    {
                        ComPort port = CheckingConnect(item);
                        AddRowToGridView(port);
                    }
                    catch (Exception e1)
                    {
                        Utils.WriteFileLog(e1.Message, item);
                    }
                    finally
                    {
                        index++;
                        if (index == listPo.Length - 1)
                        {
                            ChangeUI(() => gbSend.Enabled = true);
                            ChangeUI(() => gbReceive.Enabled = true);
                            ChangeUI(() => btnLoadPort.Enabled = true);
                            ChangeUI(() => btnConnect.Enabled = true);
                            SetDataComBoBox();
                        }
                        ChangeUI(() => lblTotalActive.Text = listPortActive.Count.ToString());
                    }
                });
                t.Start();
            }
        }

        private void btnAddSend_Click(object sender, EventArgs e)
        {
            if(cbPortSend.SelectedItem == null)
            {
                MessageBox.Show("Please choose port");
                return;
            }
            string value = ((ComboBoxItem)cbPortSend.SelectedItem).ValueString;
            if (ValidateChoosePort(value))
            {
                MessageBox.Show("Please choose other port");
                return;
            }
            ComPort port = GetPortFromList(value);
            if (!port.Status.Equals(Constant.STATUS_OK))
            {
                MessageBox.Show("Port is invalid, Please reload or choose other port");
                return;
            }
            AddRowToGridViewTransfer(port, dgvSend);
        }
        private void btnDeleteSend_Click(object sender, EventArgs e)
        {
            int rowindex = dgvSend.CurrentCell.RowIndex;
            dgvSend.Rows.RemoveAt(rowindex);
            ReloadIndexDataGridView(dgvSend, rowindex);
            dgvSend.Refresh();
        }
        private void btnClearSend_Click(object sender, EventArgs e)
        {
            dgvSend.Rows.Clear();
        }
        private void btnAddReceive_Click(object sender, EventArgs e)
        {
            if (cbPortReceive.SelectedItem == null)
            {
                MessageBox.Show("Please choose port");
                return;
            }
            string value = ((ComboBoxItem)cbPortReceive.SelectedItem).ValueString;
            if (ValidateChoosePort(value))
            {
                MessageBox.Show("Please choose other port");
                return;
            }
            ComPort port = GetPortFromList(value);
            if (!port.Status.Equals(Constant.STATUS_OK))
            {
                MessageBox.Show("Port is invalid, Please reload or choose other port");
                return;
            }
            AddRowToGridViewTransfer(port, dgvReceive);
        }
        private void btnDeleteRe_Click(object sender, EventArgs e)
        {
            int rowindex = dgvReceive.CurrentCell.RowIndex;
            dgvReceive.Rows.RemoveAt(rowindex);
            ReloadIndexDataGridView(dgvReceive, rowindex);
            dgvReceive.Refresh();
        }
        private void btnClearRe_Click(object sender, EventArgs e)
        {
            dgvReceive.Rows.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input password to process");
                return;
            }
            PASSWORD = txtPassword.Text;
            LoadListPortProcess();
            FLAG_PROCESS = true;
            i = 0;
            count = listPortProcess.Count;
            progressBar1.Maximum = count;
            progressBar1.Value = i;

            ChangeUI(() => btnStart.Enabled = false);
            ChangeUI(() => btnStop.Enabled = true);
            backgWorker.RunWorkerAsync();
        }

        private void LoadListPortProcess()
        {
            listPortProcess = new List<ComPort>();
            listPortSend = new List<ComPort>();
            listPortReveice = new List<ComPort>();
            try
            {
                foreach (DataGridViewRow row in dgvSend.Rows)
                {
                    ComPort port = new ComPort();
                    port.Name = row.Cells[1].Value.ToString();
                    port.Phone = row.Cells[2].Value.ToString();
                    port.Phone_Reveice = dgvReceive.Rows[row.Index].Cells[2].Value.ToString();
                    port.Money = double.Parse(row.Cells[3].Value.ToString());
                    listPortSend.Add(port);
                    listPortProcess.Add(port);
                }

                foreach (DataGridViewRow row in dgvReceive.Rows)
                {
                    ComPort port = new ComPort();
                    port.Name = row.Cells[1].Value.ToString();
                    port.Phone = row.Cells[2].Value.ToString();
                    port.Money = double.Parse(row.Cells[3].Value.ToString());
                    listPortReveice.Add(port);
                }

                Utils.WriteFilePort(listPortSend, Constant.PATH_FILE_SEND);
                Utils.WriteFilePort(listPortReveice, Constant.PATH_FILE_REVEICE);
            }
            catch (Exception)
            {

            } 
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            FLAG_PROCESS = false;
            if (backgWorker.WorkerSupportsCancellation == true)
            {
                backgWorker.CancelAsync();
                backgWorker.Dispose();

                while (backgWorker.IsBusy)
                {
                    Application.DoEvents();
                    backgWorker = new BackgroundWorker();
                    backgWorker.WorkerReportsProgress = true;
                    backgWorker.WorkerSupportsCancellation = true;
                    backgWorker.DoWork += new DoWorkEventHandler(backgWorker_DoWork);
                    backgWorker.ProgressChanged += new ProgressChangedEventHandler(backgWorker_ProgressChanged);
                    backgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgWorker_RunWorkerCompleted);
                }
                i = 0;
                count = 0;
                ChangeUI(() => btnStart.Enabled = true);
                ChangeUI(() => btnStop.Enabled = false);
            }
        }
        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            dgvSend.Rows.Clear();
            dgvReceive.Rows.Clear();
            listPortSend = new List<ComPort>();
            listPortReveice = new List<ComPort>();
        }
        private void rbLastConfig_CheckedChanged(object sender, EventArgs e)
        {
            listPortSend = Utils.ReadFilePort(Constant.PATH_FILE_SEND);
            listPortReveice = Utils.ReadFilePort(Constant.PATH_FILE_REVEICE);
            foreach (ComPort port in listPortSend)
            {
                AddRowToGridViewTransfer(port, dgvSend);
            }

            foreach (ComPort port in listPortReveice)
            {
                AddRowToGridViewTransfer(port, dgvReceive);
            }
        }

        #region process
        private int ProcessAction(ComPort port)
        {
            try
            {
                ChangeUI(() => lblRunning.Text = "Running : "+ port.Name);
                ATAction action = new ATAction();
                double money = Math.Floor(port.Money - 1);
                if(money > Constant.MONEY_LIMIT)
                {
                    money = Constant.MONEY_LIMIT;
                }
                Utils.WriteFileLog("Transfer money form " + port.Name + " to " + port.Phone_Reveice, port.Name);
                string reponse = action.TransferMoney(port.Name, port.Phone_Reveice, money, PASSWORD);
                if (reponse.IndexOf("successfully") >=0)
                {
                    Utils.WriteFileLog("Transfer money success", port.Name);
                    listPortProcessSuccess.Add(port);
                }
                else
                {
                    Utils.WriteFileLog("Transfer money error "+ reponse, port.Name);
                }
            }
            catch (Exception e)
            {
                Utils.WriteFileLog("Transfer money error " + e.Message, port.Name);
            }
            i++;
            return i;
        }
        private void backgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (i < count)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    if (!FLAG_PROCESS)
                    {
                        break;
                    }
                    worker.ReportProgress(ProcessAction(listPortProcess[i]));                 
                }
            }
        }
        private void backgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {

            }
            else if (!(e.Error == null))
            {

                MessageBox.Show(e.Error.Message, Constant.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (i == count || !FLAG_PROCESS)
                {
                    ChangeUI(() => btnStart.Enabled = true);
                    ChangeUI(() => btnStop.Enabled = false);
                    ChangeUI(() => lblStatus.Text = "Done");
                }
            }
        }
        private void backgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!FLAG_PROCESS)
            {
                if (backgWorker.IsBusy)
                {
                    backgWorker.CancelAsync();
                }
                ChangeUI(() => btnStart.Enabled = true);
                ChangeUI(() => btnStop.Enabled = false);
            }
            
            progressBar1.Value = i;
            ChangeUI(() => ReloadStatusDataGridView(dgvSend, i - 1));
            
        }

        #endregion process

        #region Active
        private void btnLoadPortActive_Click(object sender, EventArgs e)
        {
            Constant.FLAG_PROCESS_LOADPORT = true;
            GetSerialPortsActive();
        }

        private void chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = chkCheckAll.Checked;
            foreach (DataGridViewRow row in dgvPortActive.Rows)
            {
                ChangeUI(() => row.Cells[0].Value = flag);
            }
        }

        private void btnStartActive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassActive.Text))
            {
                MessageBox.Show("Please input password");
                return;
            }
            PASSWORD_ACTIVE = txtPassActive.Text;
            GetListPortProcess();
            if(listPortActiveProcess.Count == 0)
            {
                MessageBox.Show("Please choose port to active");
                return;
            }
            i = 0;
            count = listPortActiveProcess.Count;
            progressBar1.Maximum = count;
            progressBar1.Value = 0;
            ChangeUI(() => btnStartActive.Enabled = false);
            ChangeUI(() => btnStopActive.Enabled = true);
            FLAG_PROCESS = true;
            ProcessActiveMutiThread();
            //backgWorkerActive.RunWorkerAsync();
        }

        private void btnStopActive_Click(object sender, EventArgs e)
        {
            FLAG_PROCESS = false;
            if (backgWorkerActive.WorkerSupportsCancellation == true)
            {
                backgWorkerActive.CancelAsync();
                backgWorkerActive.Dispose();

                while (backgWorkerActive.IsBusy)
                {
                    Application.DoEvents();
                    backgWorkerActive = new BackgroundWorker();
                    backgWorkerActive.WorkerReportsProgress = true;
                    backgWorkerActive.WorkerSupportsCancellation = true;
                    backgWorkerActive.DoWork += new DoWorkEventHandler(backgWorkerActive_DoWork);
                    backgWorkerActive.ProgressChanged += new ProgressChangedEventHandler(backgWorkerActive_ProgressChanged);
                    backgWorkerActive.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgWorkerActive_RunWorkerCompleted);
                }
                i = 0;
                count = 0;
                ChangeUI(() => btnStart.Enabled = true);
                ChangeUI(() => btnStop.Enabled = false);
            }
        }
        private void GetListPortProcess()
        {
            listPortActiveProcess = new List<ComPort>();
            foreach (DataGridViewRow row in dgvPortActive.Rows)
            {
                bool process = (bool)row.Cells[0].Value;
                if (process)
                {
                    ComPort port = new ComPort();
                    port.Name = row.Cells[1].Value.ToString();
                    port.Phone = row.Cells[3].Value.ToString();
                    listPortActiveProcess.Add(port);
                }
            }
        }
        private int ProcessActive(ComPort port)
        {
            try
            { 
                ChangeUI(() => lblRunningActive.Text = "Running : " + port.Name);
                ATAction action = new ATAction();
                Utils.WriteFileLog("Active phone " + port.Phone, port.Name);
                if (!action.ActiveMoney(port.Name))
                {
                    ChangeSatusActive(4,"Error", port.Name);
                    i++;
                    return i;
                }
                ChangeSatusActive(4, "OK", port.Name);
                int loop = 0;
                Utils.WriteFileLog("Get pass from list messages : " + port.Phone, port.Name);
                List<string> ListMessages = action.GetListMessages(port.Name);
                string pass = Utils.GetPassword(ListMessages); ;
                while (string.IsNullOrEmpty(pass))
                {
                    if(loop == LOOP)
                    {
                        Utils.WriteFileLog("Can't pass from list messages : " + port.Phone, port.Name);
                        foreach (string str in ListMessages)
                        {
                            Utils.WriteFileLog(str, port.Name);
                        }
                        ChangeSatusActive(5, "No Password", port.Name);
                        i++;
                        return i;
                    }
                    ListMessages = action.GetListMessages(port.Name);
                    pass = Utils.GetPassword(ListMessages);                   
                    Thread.Sleep(1000);
                    loop++;
                }

                ChangeSatusActive(5, pass, port.Name);
                Utils.WriteFileLog("Change password phone : " + port.Phone, port.Name);
                if (action.ChangePassword(port.Name, pass, PASSWORD_ACTIVE))
                {
                    ChangeSatusActive(6, "OK", port.Name);
                }
                else
                {
                    string data = "Change password error : " + port.Phone + " - Port : "+port.Name+" - Pass :"+pass;
                    Utils.WriteFileLog(data, port.Name);
                    ChangeSatusActive(6, "ERROR", port.Name);
                }
            }
            catch (Exception e)
            {
                Utils.WriteFileLog(e.Message, port.Name);
            }
            i++;
            return i;
        }
        private void ProcessActiveMuti(ComPort port)
        {
            try
            {
                ATAction action = new ATAction();
                Utils.WriteFileLog("Active phone " + port.Phone, port.Name);
                if (!action.ActiveMoney(port.Name))
                {
                    ChangeSatusActive(4, "Error", port.Name);
                    return;
                }
                ChangeSatusActive(4, "OK", port.Name);
                int loop = 0;
                Utils.WriteFileLog("Get pass from list messages : " + port.Phone, port.Name);
                List<string> ListMessages = action.GetListMessages(port.Name);
                string pass = Utils.GetPassword(ListMessages); ;
                while (string.IsNullOrEmpty(pass))
                {
                    if (loop == LOOP)
                    {
                        Utils.WriteFileLog("Can't pass from list messages : " + port.Phone, port.Name);
                        foreach (string str in ListMessages)
                        {
                            Utils.WriteFileLog(str, port.Name);
                        }
                        ChangeSatusActive(5, "No Password", port.Name);
                        return;
                    }
                    ListMessages = action.GetListMessages(port.Name);
                    pass = Utils.GetPassword(ListMessages);
                    Thread.Sleep(1000);
                    loop++;
                }

                ChangeSatusActive(5, pass, port.Name);
                Utils.WriteFileLog("Change password phone : " + port.Phone, port.Name);
                if (action.ChangePassword(port.Name, pass, PASSWORD_ACTIVE))
                {
                    ChangeSatusActive(6, "OK", port.Name);
                }
                else
                {
                    string data = "Change password error : " + port.Phone + " - Port : " + port.Name + " - Pass :" + pass;
                    Utils.WriteFileLog(data, port.Name);
                    ChangeSatusActive(6, "ERROR", port.Name);
                }
            }
            catch (Exception e)
            {
                Utils.WriteFileLog(e.Message, port.Name);
            }
        }
        private void ProcessActiveMutiThread()
        {
            int index = 0;
            foreach (ComPort port in listPortActiveProcess)
            {
                Thread t = new Thread(
                () =>
                {
                    try
                    {
                        if (FLAG_PROCESS)
                        {
                            ProcessActiveMuti(port);
                        }
                    }
                    catch (Exception e1)
                    {
                        Utils.WriteFileLog(e1.Message, port.Name);
                    }
                    finally
                    {
                        index++;
                        if (index == listPortActiveProcess.Count - 1)
                        {
                            ChangeUI(() => btnStartActive.Enabled = true);
                            ChangeUI(() => btnStopActive.Enabled = false);
                        }
                    }
                });
                t.Start();   
            }
        }
        private void ChangeSatusActive(int indexcell, string error, string port)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPortActive.Rows)
                {
                    string name = row.Cells[1].Value.ToString();
                    if (name.Equals(port))
                    {
                        ChangeUI(() => row.Cells[indexcell].Value = error);
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void backgWorkerActive_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (i < count)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    if (!FLAG_PROCESS)
                    {
                        break;
                    }
                    worker.ReportProgress(ProcessActive(listPortActiveProcess[i]));

                }
            }
        }
        private void backgWorkerActive_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {

            }
            else if (!(e.Error == null))
            {

                MessageBox.Show(e.Error.Message, Constant.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (i == count || !FLAG_PROCESS)
                {
                    ChangeUI(() => btnStartActive.Enabled = true);
                    ChangeUI(() => btnStopActive.Enabled = false);
                    ChangeUI(() => lblRunningActive.Text = "Done");
                }
            }
        }
        private void backgWorkerActive_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!FLAG_PROCESS)
            {
                if (backgWorkerActive.IsBusy)
                {
                    backgWorkerActive.CancelAsync();
                }
                ChangeUI(() => btnStartActive.Enabled = true);
                ChangeUI(() => btnStopActive.Enabled = false);
            }
            progressBar1.Value = i;

        }

        #endregion Active
    }
}
