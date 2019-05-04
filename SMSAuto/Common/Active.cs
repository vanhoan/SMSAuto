using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SMSAuto.Common
{
    class Active
    {

        private string url = "http://www.hnpublic.com/p/youtubeplic.html";
        
        List<string> keyActive = new List<string>();

        private string START = "[YoutubeTools-Start]";
        private string END = "[YoutubeTools-End]";
        private string BR_KEY = "<br />";
        private string PATH_KEY_FILE = "WebDriver.Make.dll";
        private string PATH_AGENT_FILE = "";

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void getKeyID()
        {
            keyActive = new List<string>();
            char[] array1 = { '\n' };
            string readerContent = "";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 60*60*1000;

                using (var response = request.GetResponse())
                using (var responseStream = response.GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    readerContent = reader.ReadToEnd();
                }

                int indexStart = readerContent.IndexOf(START + BR_KEY);
                int indexEnd = readerContent.IndexOf(END);
                int length = indexEnd - (indexStart + START.Length + BR_KEY.Length);
                string arraysKey = readerContent.Substring(indexStart + START.Length + BR_KEY.Length, length);
                arraysKey = arraysKey.Replace(BR_KEY, "");
                string[] data = arraysKey.Trim().Split(array1);
                for (int i = 0; i < data.Length; i++ )
                {
                    if (!data[i].Trim().Equals(""))
                    {
                        keyActive.Add(data[i]);
                    }
                }
            }
            catch (Exception)
            {
                keyActive = new List<string>();
            }
        }

        public bool checkActive()
        {
            if (!File.Exists(PATH_KEY_FILE))
            {
                return false;
            }
            getKeyID();
            if (keyActive.Count > 0)
            {
                StreamReader reader = new StreamReader(PATH_KEY_FILE);
                try
                {
                    string key = reader.ReadLine();
                    foreach (string pair in keyActive)
                    {
                        string encode = encodeMd5(pair);
                        if (encode.Equals(key))
                        {
                            reader.Close();
                            return true;
                        }
                    }

                }
                catch (Exception)
                {
                    reader.Close();
                    return false;
                }
                reader.Close();
            }
            
            return false;
        }

        public bool checkAddKey(string key)
        {
            getKeyID();
            if (keyActive.Contains(key))
            {
                bool exists = System.IO.Directory.Exists(PATH_AGENT_FILE);

                if (!exists)
                    System.IO.Directory.CreateDirectory(PATH_AGENT_FILE);

                StreamWriter write = new StreamWriter(PATH_KEY_FILE, false);
                try
                {
                    string encode = encodeMd5(key);
                    write.WriteLine(encode);
                    write.Flush();
                    write.Close();
                    
                }catch(Exception){
                    write.Close();
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private string encodeMd5(string key)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(key);
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] hash = md5.ComputeHash(plainTextBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i]);
            }
            return sb.ToString();
        }

        public bool checkFormatKey(string key)
        {
            return true;
        }
    }
}
