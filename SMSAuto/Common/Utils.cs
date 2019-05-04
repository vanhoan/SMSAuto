using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Web;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Data;
using System.Text.RegularExpressions;
using System.Linq;
using SMSAuto.Model;

namespace SMSAuto.Common
{
    public class Utils
    {

        static Random random = new Random();

        /// <summary>
        /// Create directory (throw exception)
        /// </summary>
        /// <param name="path"></param>
        public static void CreateDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    // Try to create the directory.
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ioex)
            {
                throw ioex;
            }
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            if (items == null || items.Count == 0)
            {
                return dataTable;
            }
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        #region File
        public static List<string> GetListDataFromFile(string file)
        {
            List<string> listData = new List<string>();
            if (!File.Exists(file))
            {
                return listData;
            }
            StreamReader fileReader = new StreamReader(file);
            try
            {
                while (!fileReader.EndOfStream)
                {
                    string data = fileReader.ReadLine().Trim();
                    listData.Add(data);
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                fileReader.Close();
            }
            return listData;
        }       
        public static void WriteFile(string data, string file)
        {
            StreamWriter csvFileWriter = new StreamWriter(file, true, Encoding.UTF8);
            try
            {
                csvFileWriter.WriteLine(data);
                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception)
            {
                csvFileWriter.Close();
            }
        }
        public static void WriteFileAccount(string data, string file)
        {
            DateTime date = DateTime.Now;
            string datestr = date.ToString("yyyy-MM-dd");
            string path = string.Format(file, datestr);
            StreamWriter csvFileWriter = new StreamWriter(path, true, Encoding.UTF8);
            try
            {
                csvFileWriter.WriteLine(data);
                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception)
            {
                csvFileWriter.Close();
            }
        }
        public static void WriteFileLog(string data)
        {
            DateTime date = DateTime.Now;
            string datestr = date.ToString("yyyy-MM-dd");
            if (!Directory.Exists(Constant.PATH_LOG))
            {
                Directory.CreateDirectory(Constant.PATH_FILE_LOG);
            }
            string file = string.Format(Constant.PATH_FILE_LOG, datestr);
            StreamWriter csvFileWriter = new StreamWriter(file, true, Encoding.UTF8);
            try
            {
                csvFileWriter.WriteLine(data);
                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception)
            {
                csvFileWriter.Close();
            }
        }
        public static string ReadFile(string file)
        {
            string data = "";
            if (!File.Exists(file))
            {
                return data;
            }
            StreamReader fileReader = new StreamReader(file);
            try
            {
                while (!fileReader.EndOfStream)
                {
                    data = fileReader.ReadLine();
                    break;
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                fileReader.Close();
            }
            return data;
        }
        public static void ProcessDeleteLine(string line, string file)
        {
            try
            {
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(file).Where(l => l != line);

                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete(file);
                File.Move(tempFile, file);
            }catch(Exception){

            }
        }
        #endregion File

        #region Reponse
        public static string GetStatus(string reponse)
        {
            if(reponse.IndexOf("CUSD: 2") >= 0)
            {
                return Constant.STATUS_OK;
            }
            if (reponse.IndexOf("CUSD: 4") >= 0)
            {
                return Constant.STATUS_ERROR;
            }
            else
            {
                return Constant.STATUS_TIMEOUT;
            }
        }
        public static string GetDescription(string reponse)
        {
          
            reponse = reponse.Replace("OK","");
            reponse = reponse.Replace("+", "");
            reponse = reponse.Replace("ATCUSD=1,\"*101#\",15\r", "");
            reponse = reponse.Replace("AT+CUSD=1,\"*101#\",15\r", "");
            reponse = reponse.Replace("CUSD: 2", "");
            return reponse;
           
        }
        public static string GetPhone(string reponse)
        {
            if (string.IsNullOrEmpty(reponse))
            {
                return "";
            }
            Regex regex = new Regex(@"[0-9]{8,12}");
            Match match = regex.Match(reponse);
            if (match.Success)
            {
                return match.Value.Replace("855","0");
            }
            else
            {
                return "";
            }
        }
        public static string GetCurrency(string reponse)
        {
            //if (reponse.IndexOf("VND") >= 0)
            //{
            //    return "VND";
            //}
            //Regex regex = new Regex(@"[0-9]+[d]+");
            //Match match = regex.Match(reponse);
            //if (match.Success)
            //{
            //    return "VND";
            //}
            //if (reponse.IndexOf("USD") >= 0)
            //{
            //    return "USD";
            //}
            
            return "USD";
        }
        public static double GetMoney(string reponse)
        {
            try
            {
                if (string.IsNullOrEmpty(reponse))
                {
                    return 0;
                }
                Regex regex = new Regex(@"[0-9.]+[ ]?[V]+[N]+[D]+");
                Match match = regex.Match(reponse);
                if (match.Success)
                {
                    string value = match.Value.Replace("VND", "");
                    return double.Parse(value.Trim());
                }
                regex = new Regex(@"[,.0-9 ]+[d]");
                match = regex.Match(reponse);
                if (match.Success)
                {
                    string value = match.Value.Replace("d", "");
                    return double.Parse(value.Trim());
                }

                regex = new Regex(@"[0-9.]+[ ]?[U][S][D]");
                match = regex.Match(reponse);
                if (match.Success)
                {
                    string value = match.Value.Replace("USD", "");
                    return double.Parse(value.Trim());
                }
            }
            catch (Exception)
            {
                return 0;
            }
            return 0;
        }
        #endregion Reponse

        public static string RandomString(int length)
        {          
            string chars = "ABCDEFGHIJKLMOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumber(int length)
        {
            string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
