using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace SMSAuto.Action
{
    public class ATAction
    {
        static SerialPort port;
        public static string Response = "";
        public void Initialization(string NamePort)
        {
            port = new SerialPort(NamePort, 115200);
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.ReadTimeout = 3000;
            port.WriteTimeout = 5000;
            //port.DataReceived += port_DataReceived;
        }

        public bool ConnectPort()
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                String v = System.Text.Encoding.UTF8.GetString(buf, 0, buf.Length);
                var result = Encoding.ASCII.GetString(buf);
                Response = result;
            }
            catch (Exception)
            {
               
            }
        }

        public string ResponseReslut()
        {
            return Response;
        }

        public string SendCommand(string conmmand)
        {
            if (!port.IsOpen)
            {
                port.Open();
            }
            port.WriteLine(conmmand);
            Thread.Sleep(5000);
            string ss = port.ReadExisting();
            
            return ss;
        }

        public string CheckBanlce(string port)
        {
            SerialPort serialPort = new SerialPort(port, 115200);
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = 3000;
            serialPort.WriteTimeout = 5000;
            serialPort.Open();
            string command = "AT+CUSD=1,\"*101#\",15\r";
            serialPort.WriteLine(command);
            Thread.Sleep(5000);
            string ss = serialPort.ReadExisting();
            serialPort.Close();
            serialPort.Dispose();
            return ss;
        }

        public void Disconnect()
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                    port.Dispose();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
