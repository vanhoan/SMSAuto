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
            serialPort.ReadTimeout = 20000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = Constant.COMMAND_BALANCE;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 5 || !Constant.FLAG_PROCESS_LOADPORT)
                {
                    break;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("CUSD: 2") >=0)
                    {
                        isReading = false;
                    } 
                    else
                    {
                        Thread.Sleep(2000);
                        i++;
                    }
                }
                catch (Exception e)
                {
                    ss = e.Message;
                    break;
                }
               
            }
            
            serialPort.Close();
            serialPort.Dispose();
            return ss;
        }
        public string CheckConnect(string port)
        {
            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 20000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = Constant.COMMAND_TEST;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 3)
                {
                    break;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("OK") >= 0)
                    {
                        isReading = false;
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        i++;
                    }
                }
                catch (Exception e)
                {
                    ss = e.Message;
                    break;
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
                if (i == 5 || !Constant.FLAG_PROCESS_LOADPORT)
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
                        string value = match.Value;
                        string frist = value.Substring(0, 3);
                        string last = value.Substring(3, value.Length - frist.Length);
                        frist = frist.Replace("855", "0");
                        ss = frist + last;
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
        public bool ActiveMoney(string port)
        {
            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 3000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = Constant.COMMAND_ACTIVE;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 5)
                {
                    Utils.WriteFileLog("Process active port " + port + " is failed" );
                    return false;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("OK") >= 0 || ss.IndexOf("CUSD: 2") >= 0)
                    {
                        return true;
                    }
                    else if(ss.IndexOf("ERROR") >= 0)
                    {
                        Utils.WriteFileLog("Process active port " + port + " is failed " + ss);
                        return false;
                    }
                    else{
                        Thread.Sleep(2000);
                        i++;
                    }
                }
                catch (Exception e)
                {
                    Utils.WriteFileLog("Process active port " + port + " is failed " + e.Message);
                    return false;
                }

            }
            serialPort.Close();
            serialPort.Dispose();
            return true;
        }
        public bool ChangePassword(string port, string pass, string newpass)
        {
            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 3000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = string.Format(Constant.COMMAND_CHNAGE_PASS,pass,newpass);
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 5)
                {
                    Utils.WriteFileLog("Process change pass port " + port + " is failed");
                    return false;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("OK") >= 0 || ss.IndexOf("CUSD: 2") >= 0)
                    {
                        return true;
                    }
                    else if (ss.IndexOf("ERROR") >= 0)
                    {
                        Utils.WriteFileLog("Process change pass port " + port + " is failed " + ss);
                        return false;
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        i++;
                    }
                }
                catch (Exception e)
                {
                    Utils.WriteFileLog("Process change pass port " + port + " is failed " + e.Message);
                    return false;
                }

            }
            serialPort.Close();
            serialPort.Dispose();
            return true;
        }

        public List<string> GetListMessages(string port)
        {
            List<string> ListMessages = new List<string>();

            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 3000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();

            if (!SetFormatText(serialPort))
            {
                Utils.WriteFileLog("Can't Use message format text mode");
                return ListMessages;
            }
            if (!SetUseCharacter(serialPort))
            {
                Utils.WriteFileLog("Can't Use character set GSM");
                return ListMessages;
            }
            if (!SetSelectSimStorage(serialPort))
            {
                Utils.WriteFileLog("Can't set select SIM storage");
                return ListMessages;
            }
            string command = Constant.COMMAND_GET_LIST_MESSAGES;
            serialPort.WriteLine(command);
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                try
                {
                    string ss = serialPort.ReadLine();
                    if (!string.IsNullOrEmpty(ss))
                    {
                        ListMessages.Add(ss);
                    }
                    if (ss.IndexOf("OK") >= 0 || ss.IndexOf("ERROR") >= 0)
                    {
                        isReading = false;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        i++;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(1000);
                    i++;
                }

            }
            serialPort.Close();
            serialPort.Dispose();
            return ListMessages;
        }
        private bool SetFormatText(SerialPort serialPort)
        {
            string command = Constant.COMMAND_SET_MESSAGES_FORMAT_TEXT;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 3)
                {
                    return false;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("OK") >= 0)
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
                    return false;
                }
            }
            return true;
        }
        private bool SetUseCharacter(SerialPort serialPort)
        {
            string command = Constant.COMMAND_SET_MESSAGES_CHARACTER;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 3)
                {
                    return false;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("OK") >= 0)
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
                    return false;
                }
            }
            return true;
        }
        private bool SetSelectSimStorage(SerialPort serialPort)
        {
            string command = Constant.COMMAND_SET_SELECT_SIM_STORAGE;
            serialPort.WriteLine(command);
            string ss = "";
            int i = 0;
            bool isReading = true;
            while (isReading)
            {
                if (i == 3)
                {
                    return false;
                }
                try
                {
                    ss += serialPort.ReadExisting();
                    if (ss.IndexOf("OK") >= 0)
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
                    return false;
                }
            }
            return true;
        }
    }
}
