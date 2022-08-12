using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsyncTask = System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WinPEImager.Classes.Enums;
using System.Drawing;

namespace WinPEImager.Classes
{
    internal class CMDR
    {

        private static object locker = new object();
        public Process process;
        static CMDR instance;
        private TextBox consoleOutput;
        private List<string> values = new List<string>();

        private ProcessStartInfo startInfo;

        protected CMDR() {

            process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;


            process.ErrorDataReceived += (s, e) => {
                if (!String.IsNullOrEmpty(e.Data))
                {
                    values.Add("! > " + e.Data);
                    consoleOutput.Invoke(new MethodInvoker(delegate {consoleOutput.AppendText("ERROR > "+e.Data); consoleOutput.AppendText(Environment.NewLine); }));
                    Console.WriteLine(e.Data);
                }
            };

            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {

                if (!String.IsNullOrEmpty(e.Data))
                {
                    consoleOutput.Invoke(new MethodInvoker(delegate {consoleOutput.AppendText(e.Data); consoleOutput.AppendText(Environment.NewLine); }));
                    Console.WriteLine(e.Data);

                }
            });

           

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
        public CMDR SetConsoleOutput(TextBox f)
        {
            consoleOutput = f;
            return this;
        }
        public async AsyncTask.Task<bool> RunCommand(Task task)
        {



            values.Clear();


            if (task.GetTaskType() == TYPE.Command)
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.WorkingDirectory = @"C:\";
                process.StartInfo.Arguments = "/C " + task.command;


                
            }
            if (task.GetTaskType() == TYPE.Bat)
            {
                //process.StartInfo.FileName = "cmd.exe";
                //process.StartInfo.WorkingDirectory = Config.Instance().GetWorkingDir() + @"\Required\";
                //process.StartInfo.Arguments =  task.command;
                //Console.WriteLine(process.StartInfo.WorkingDirectory);
                process.StartInfo.Arguments = "/C "+Config.Instance().GetWorkingDir() + @"\Required\" + task.command;



            }
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();



            await AsyncTask.Task.Delay(1000);

            process.WaitForExit();

            process.CancelErrorRead();
            process.CancelOutputRead();




            if (values.Count() != 0)
                {
                    Console.WriteLine("ERRORS: " + values.Count());
                    return false;
                }
                else
                {
                    Console.WriteLine("Success");
                    return true;
                }


        }
    }
}
