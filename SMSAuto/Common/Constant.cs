﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSAuto.Common
{
    public class Constant
    {
        public static string PATH_LOG = "agents\\SMSAuto\\Logs";
        public static string PATH_FILE_LOG = "agents\\SMSAuto\\Logs\\{0}_log.txt";

        public static string IMAGE_TEMP = "agents\\SMSAuto\\Temp\\imagetemp.png";
        public static string IMAGE_COMPLATE = "agents\\SMSAuto\\Temp\\complete.png";
        public static string TITLE = "Auto Transfer Money";
        public static int FLAG_RECOVER = 0;

        public static string STATUS_OK = "Ready";
        public static string STATUS_TIMEOUT = "Timeout";
        public static string STATUS_ERROR = "Error";
    }
}
