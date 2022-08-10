using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace WinPEImager.Classes
{
    internal class CMDR
    {

        private static object locker = new object();
        private Process process;
        static CMDR instance;

        private ProcessStartInfo startInfo;
        private string error;

        protected CMDR() {
           startInfo = new ProcessStartInfo("cmd.exe");
           startInfo.UseShellExecute = false;
           startInfo.RedirectStandardOutput = true;
           startInfo.RedirectStandardInput = true;
           
           startInfo.RedirectStandardError = true;

           process = Process.Start(startInfo);
           //this.error = process.StandardError.ReadToEnd();

        }

        public static CMDR GetProcess()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CMDR();
                    }
                }
            }
            return instance;
        }

        public bool RunCommand(string command)
        {

            //startInfo.Arguments = "/C " + command;
            //process = Process.Start(startInfo);
           

            //using (StreamWriter sw = process.StandardInput)
            //{
            //    if (sw.BaseStream.CanWrite)
            //    {
            //        sw.WriteLine(command);
                    
            //    }
            //}

            error = process.StandardError.ReadToEnd();

            if (error != string.Empty)
            {
                Console.WriteLine("ERRORS: " + error);
                return false;
            }
            else
            {
                Console.WriteLine("ERRORS: " + error);
                return true;
            }

            
        
        }
    }
}
