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
            using (var searcher = new ManagementObjectSearcher
                ("SELECT * FROM WIN32_SerialPort"))
            {
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                return ports.Select(p =>
                {
                    ComPort c = new ComPort();
                    c.name = p.GetPropertyValue("DeviceID").ToString();
                    c.vid = p.GetPropertyValue("PNPDeviceID").ToString();
                    c.description = p.GetPropertyValue("Caption").ToString();

                    Match mVID = Regex.Match(c.vid, vidPattern, RegexOptions.IgnoreCase);
                    Match mPID = Regex.Match(c.vid, pidPattern, RegexOptions.IgnoreCase);

                    if (mVID.Success)
                        c.vid = mVID.Groups[1].Value;
                    if (mPID.Success)
                        c.pid = mPID.Groups[1].Value;

                    return c;

                }).ToList();
            }
        }


        private void SetDataGribView(List<ComPort> listdata)
        {
            dataGridView1.Rows.Clear();
            foreach (ComPort str in listdata)
            {
                AddRowToGridView(str);
            }
        }

        private void AddRowToGridView(ComPort gmail)
        {
            DataGridViewTextBoxCell userCell = new DataGridViewTextBoxCell();
            userCell.Value = gmail.pid;
            

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
    }
}
