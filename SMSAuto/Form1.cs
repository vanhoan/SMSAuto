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
    public partial class Form1 : Form
    {
        SerialPort sp = null;
        private const string vidPattern = @"VID_([0-9A-F]{4})";
        private const string pidPattern = @"PID_([0-9A-F]{4})";
        List<ComPort> listPort = new List<ComPort>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            //show list of valid com ports
            listPort = GetSerialPorts();

            SetDataGribView(listPort);
        }

        private List<ComPort> GetSerialPorts()
        {
            List<ComPort> listdata = new List<ComPort>();
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {
                ComPort c = new ComPort();
                c.name = item;
                listdata.Add(c);
            }
            return listdata;
        }


        private void SetDataGribView(List<ComPort> listdata)
        {
            ChangeUI(() => lblTotal.Text = listdata.Count.ToString());
            dataGridView1.Rows.Clear();
            foreach (ComPort str in listdata)
            {
                AddRowToGridView(str);
            }
        }

        private void AddRowToGridView(ComPort gmail)
        {
            DataGridViewTextBoxCell userCell = new DataGridViewTextBoxCell();
            userCell.Value = gmail.name;
            

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.AddRange(userCell);
            ChangeUI(() => dataGridView1.Rows.Add(newRow));
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

        private void Call(string nameCom)
        {
            try
            {
                SerialPort port = new SerialPort();
                port.PortName = nameCom;
                port.Parity = Parity.None;
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.ReadTimeout = 3000;
                port.WriteTimeout = 3000;
                port.DataReceived += port_DataReceived;
                port.Open();
                string cmd = "AT+CUSD=1,\"*101#\",15";
                port.WriteLine(cmd + "\r");
                Thread.Sleep(500);
                string ss = port.ReadExisting();
                if (ss.EndsWith("\r\nOK\r\n"))
                {
                    MessageBox.Show("Modem is connected \r Calling : ");
                }
                port.Close();
                port.Dispose();
            }catch(Exception e){
                MessageBox.Show("Call : " + e.Message);
            }
            
        }

        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string message = "";
                SerialPort spL = (SerialPort)sender;
                byte[] buf = new byte[spL.BytesToRead];
                spL.Read(buf, 0, buf.Length);

                foreach (Byte b in buf)
                {
                    message += b.ToString();
                }

                var result = Encoding.ASCII.GetString(buf);
                MessageBox.Show(message);

            }catch(Exception e1){
                MessageBox.Show(e1.Message);
            }
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                ChangeUI(() => lblPortSelect.Text = value);
                Call(value);
            }
        }
    }
}
