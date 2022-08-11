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
        public Process process;
        static CMDR instance;

        private List<string> values = new List<string>();

        private ProcessStartInfo startInfo;
        private string error;

        protected CMDR() {

            process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;


            process.ErrorDataReceived += (s, e) => {
                lock (values)
                {
                    values.Add("! > " + e.Data);
                }
            };

            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {

                if (!String.IsNullOrEmpty(e.Data))
                {
                               
                    Console.WriteLine(e.Data);

                }
            });

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

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

        public async Task<bool> RunCommand(Task task)
        {
            values.Clear();
       
            //process.BeginErrorReadLine();
            //process.BeginOutputReadLine();

            StreamWriter CMDInput = process.StandardInput;
            
            string InputString = "CMD.exe /C "+ task.command;
            CMDInput.WriteLine(InputString);




            if (values.Count() != 0)
                {
                    Console.WriteLine("ERRORS: " + values.Count());
                    return false;
                }
                else
                {
                    Console.WriteLine("Success: " + error);
                    return true;
                }


        }
    }
}
