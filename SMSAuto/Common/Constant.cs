using System;
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
        public static string PATH_FILE_SEND = "agents\\SMSAuto\\Config\\send.txt";
        public static string PATH_FILE_REVEICE = "agents\\SMSAuto\\Config\\reveice.txt";
        public static string PATH_FILE_LOOP = "agents\\SMSAuto\\Config\\loop.txt";
        public static string PATH_FILE_CHANGE_ERROR = "agents\\SMSAuto\\Config\\Change.txt";

        public static string IMAGE_TEMP = "agents\\SMSAuto\\Temp\\imagetemp.png";
        public static string IMAGE_COMPLATE = "agents\\SMSAuto\\Temp\\complete.png";
        public static string TITLE = "Auto Transfer Money";
        public static int FLAG_RECOVER = 0;
        public static double MONEY_LIMIT = 50;

        public static bool FLAG_PROCESS_LOADPORT = true;

        public static string STATUS_OK = "Ready";
        public static string STATUS_TIMEOUT = "Timeout";
        public static string STATUS_ERROR = "Error";

        public static string COMMAND_TEST = "AT\r";
        public static string COMMAND_BALANCE = "AT+CUSD=1,\"*101#\",15\r";
        public static string COMMAND_PHONE = "AT+CNUM\r";
        public static string COMMAND_TRANSFER = "AT+CUSD=1,\"*100*{0}*{1}*{2}#\",15\r";
        public static string COMMAND_ACTIVE = "AT+CUSD=1,\"*000*1#\",15\r";
        //Use message format "Text mode"
        public static string COMMAND_SET_MESSAGES_FORMAT_TEXT = "AT+CMGF=1\r";
        //Use character set GSM
        public static string COMMAND_SET_MESSAGES_CHARACTER = "AT+CSCS=\"GSM\"\r";
        //Select SIM storage
        public static string COMMAND_SET_SELECT_SIM_STORAGE = "AT+CPMS=\"SM\"\r";
        public static string COMMAND_GET_LIST_MESSAGES = "AT+CMGL=\"ALL\"\r";
        public static string COMMAND_CHNAGE_PASS = "AT+CUSD=1,\"*000*{0}*{1}#\",15\r";
    }
}
