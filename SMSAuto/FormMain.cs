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

        SerialPort sp = null;
        private const string vidPattern = @"VID_([0-9A-F]{4})";
        private const string pidPattern = @"PID_([0-9A-F]{4})";
        List<ComPort> listPort = new List<ComPort>();
        public FormMain()
        {
            InitializeComponent();
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
                    //check = active.checkActive();
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

        private void ProcessAction(string port)
        {
            ATAction action = new ATAction();
            action.Initialization(port);
           
            try
            {
                action.ConnectPort();
                string command = "AT+CUSD=1,\"*101#\",15\r";
                action.SendCommand(command);
                string reponse = action.ResponseReslut();
                int a = 0;
                while (string.IsNullOrEmpty(reponse))
                {
                    if (a == 5)
                    {
                        break;
                    }
                    Thread.Sleep(1000);
                    reponse = action.ResponseReslut();                       
                    a++;
                }
            }
            catch (Exception)
            {

            }
        }

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
            ChangeUI(() => cbCurrency.Items.Clear());
            List<ComPort> listnew = listPort.OrderBy(x => x.Name).ToList();
            foreach (var port in listnew)
            {
                ChangeUI(() => cbPortSend.Items.Add(new ComboBoxItem(port.Name, port.Name)));
                ChangeUI(() => cbPortReceive.Items.Add(new ComboBoxItem(port.Name, port.Name)));
                if (!ListCurrency.Contains(port.Currency))
                {
                    ListCurrency.Add(port.Currency);
                    ChangeUI(() => cbCurrency.Items.Add(new ComboBoxItem(port.Currency, port.Currency)));
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
            c.Description = Utils.GetDescription(reponse);
            c.Phone = Utils.GetPhone(reponse);
            c.Currency = Utils.GetCurrency(c.Description);
            c.Money = Utils.GetMoney(c.Description);
            listPort.Add(c);
            return c;
        }
        private void AddRowToGridView(ComPort gmail)
        {
            DataGridViewTextBoxCell userCell = new DataGridViewTextBoxCell();
            userCell.Value = gmail.Name;
            DataGridViewTextBoxCell userStatus = new DataGridViewTextBoxCell();
            userStatus.Value = gmail.Status;
            DataGridViewTextBoxCell userInfor= new DataGridViewTextBoxCell();
            userInfor.Value = gmail.Description;

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.AddRange(userCell, userStatus, userInfor);
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
        private void btnLoadPort_Click(object sender, EventArgs e)
        {
            ChangeUI(() => btnLoadPort.Enabled = false);
            ChangeUI(() => gbSend.Enabled = false);
            ChangeUI(() => gbReceive.Enabled = false);

            GetSerialPorts();
            
        }
        private void txtAmout_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        }
    }
}
