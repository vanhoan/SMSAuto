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
        List<ComPort> listPortSend = new List<ComPort>();
        List<ComPort> listPortReveice = new List<ComPort>();

        private int i = 0;
        private int count = 0;
        private bool FLAG_PROCESS = true;
        private string PASSWORD = "";
        private BackgroundWorker backgWorker = new BackgroundWorker();

        public FormMain()
        {
            InitializeComponent();
            backgWorker.WorkerReportsProgress = true;
            backgWorker.WorkerSupportsCancellation = true;
            backgWorker.DoWork += new DoWorkEventHandler(backgWorker_DoWork);
            backgWorker.ProgressChanged += new ProgressChangedEventHandler(backgWorker_ProgressChanged);
            backgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgWorker_RunWorkerCompleted);
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
            int index = 0;
            foreach (string item in listPo)
            {
                Thread t = new Thread(
                () =>
                {
                    try
                    {
                        ComPort port = GetPortInfor(item);
                        AddRowToGridView(port);                     
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        index++;
                        if (index == listPo.Length-1)
                        {
                            ChangeUI(() => gbSend.Enabled = true);
                            ChangeUI(() => gbReceive.Enabled = true);
                            ChangeUI(() => btnLoadPort.Enabled = true);
                            SetDataComBoBox();
                        }
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
            string reponse = action.CheckBanlce(port);
            c.Status = Utils.GetStatus(reponse);
            c.Phone = Utils.GetPhone(reponse);
            if (c.Status.Equals(Constant.STATUS_OK) && string.IsNullOrEmpty(c.Phone))
            {
                 c.Phone = action.GetPhoneNumber(port);
            }
            c.Currency = Utils.GetCurrency(reponse);
            c.Money = Utils.GetMoney(reponse);
            if (!string.IsNullOrEmpty(reponse))
            {
                reponse = reponse.Replace(c.Phone, "");
            }
            
            c.Description = Utils.GetDescription(reponse);
            listPort.Add(c);
            return c;
        }
        private void AddRowToGridView(ComPort gmail)
        {
            DataGridViewTextBoxCell userCell = new DataGridViewTextBoxCell();
            userCell.Value = gmail.Name;
            DataGridViewTextBoxCell userStatus = new DataGridViewTextBoxCell();
            userStatus.Value = gmail.Status;
            DataGridViewTextBoxCell userPhone = new DataGridViewTextBoxCell();
            userPhone.Value = gmail.Phone;
            DataGridViewTextBoxCell userInfor= new DataGridViewTextBoxCell();
            userInfor.Value = gmail.Description;

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.AddRange(userCell, userStatus, userPhone, userInfor);
            if (gmail.Status.Equals(Constant.STATUS_OK))
            {
                newRow.DefaultCellStyle.BackColor = Color.LightGreen;
            }
            ChangeUI(() => dgvPort.Rows.Add(newRow));        
        }
        private void AddRowToGridViewTransfer(ComPort port, DataGridView dgv)
        {
            int row = dgv.RowCount;
            DataGridViewTextBoxCell userRow = new DataGridViewTextBoxCell();
            userRow.Value = row+1;
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

        private void btnLoadPort_Click(object sender, EventArgs e)
        {
            ChangeUI(() => btnLoadPort.Enabled = false);
            ChangeUI(() => gbSend.Enabled = false);
            ChangeUI(() => gbReceive.Enabled = false);

            GetSerialPorts();
            
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
                //string command = string.Format(Constant.COMMAND_TRANSFER, port.Phone_Reveice, Math.Floor(port.Money - 1), PASSWORD);
                ChangeUI(() => lblRunning.Text = "Running : "+ port.Name);
                ATAction action = new ATAction();
                 string reponse = action.TransferMoney(port.Name, port.Phone_Reveice, Math.Floor(port.Money - 1), PASSWORD);
                if (reponse.IndexOf("successfully") >=0)
                {
                    listPortProcessSuccess.Add(port);
                }
            }
            catch (Exception)
            {

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

       
    }
}
