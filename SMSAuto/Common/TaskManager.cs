using SMSAuto.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSAuto.Common
{
    class TaskManager
    {
        public void KillProcess(string appname)
        {
            try
            {
                Process[] processes = Process.GetProcesses(".");
                foreach (Process p in processes)
                {
                    try
                    {
                        if (p.ProcessName.ToLower().Equals(appname.ToLower()) || p.ProcessName.ToLower().IndexOf(appname.ToLower()) >= 0)
                        {
                            p.Kill();
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }
    }
}
