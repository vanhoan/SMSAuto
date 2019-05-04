using SMSAuto.Common;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace SMSAuto.Action
{
    public class ATAction
    {

        public string CheckBanlce(string port)
        {
            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 3000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = Constant.COMMAND_BALANCE;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 5)
                {
                    break;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("CUSD: 2") >=0 || ss.IndexOf("CUSD: 4") >= 0 || ss.IndexOf("ERROR") >= 0)
                    {
                        isReading = false;
                    } 
                    else
                    {
                        Thread.Sleep(2000);
                        i++;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    i++;
                }
               
            }
            
            serialPort.Close();
            serialPort.Dispose();
            return ss;
        }

        public string GetPhoneNumber(string port)
        {
            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 3000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = Constant.COMMAND_PHONE;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 5)
                {
                    break;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    Regex regex = new Regex(@"[0-9]{8,12}");
                    Match match = regex.Match(ss);
                    if (match.Success)
                    {
                        isReading = false;
                        ss = match.Value.Replace("855", "0");
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        i++;
                    }  
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    i++;
                }  
            }

            serialPort.Close();
            serialPort.Dispose();
            return ss;
        }

        public string TransferMoney(string port,string phone, double money, string pass)
        {
            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 3000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = string.Format(Constant.COMMAND_TRANSFER,phone , money, pass);
            Utils.WriteFileLog(command);
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 5)
                {
                    break;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("CUSD: 2") >= 0 || ss.IndexOf("ERROR") >= 0)
                    {
                        isReading = false;
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        i++;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    i++;
                }

            }
            serialPort.Close();
            serialPort.Dispose();
            Utils.WriteFileLog(ss);
            return ss;
        }
    }
}
