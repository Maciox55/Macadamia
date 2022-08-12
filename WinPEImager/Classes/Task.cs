using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AsyncTask =  System.Threading.Tasks.Task;
using WinPEImager.Classes.Enums;

namespace WinPEImager.Classes
{
    public class Task
    {
        public string command;
        private string error;
        private string path;
        private Image parentImage;
        private TYPE type;

        private bool sucessful;
        private STATUS currentStatus;

        public Task(string command) {
            this.command = command;
            currentStatus = STATUS.Idle;
        }
        public Task(string command, TYPE t)
        {
            this.command = command;
            this.type = t;
            currentStatus = STATUS.Idle;
        }
        public Task(string command,string p,Image pimage, TYPE t)
        {
            this.command = command;
            this.path = p;
            this.type = t;
            this.parentImage = pimage;
            currentStatus = STATUS.Idle;
        }
        public void SetStatus(STATUS newStatus)
        { 
            currentStatus = newStatus;
        
        }

        public STATUS GetStatus()
        {
            return currentStatus;
        }
        public TYPE GetTaskType()
        {
            return type;
        }

        public Image GetParentImage() {
            return parentImage;
        }


        public ListViewItem ToListItem() {

            ListViewItem item = new ListViewItem(command, (int)currentStatus);

            return item;
        }

        public Task AddPath(string p)
        {
            this.path = p;
            return this;
        }

        public async AsyncTask Execute() {

            try
            {
                //Check if the status is not Sucessful, otherwise skip the operation.
                if (this.currentStatus != STATUS.Sucessful)
                {
    
                    this.currentStatus = STATUS.Processing;

                    sucessful = await AsyncTask.Run(()=> CMDR.GetProcess().RunCommand(this));



                    if (!sucessful)
                    {
                        Console.WriteLine("ERRORS: " + error);
                        this.currentStatus = STATUS.Failed;
                        Console.WriteLine(this.currentStatus);
                    }
                    else
                    {
                        
                        this.currentStatus = STATUS.Sucessful;
                        Console.WriteLine(this.currentStatus);
                    }
                    await AsyncTask.Delay(1000);
                }
                else {
                    MessageBox.Show("Task: " + this.command + " Has already been executed");
                    
                }

            }
            catch (Exception e) {
                Console.WriteLine("Exception: "+e);
                this.currentStatus = STATUS.Failed;
            }
        }
    }
}
