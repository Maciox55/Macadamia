using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPEImager.Classes.Enums;

namespace WinPEImager.Classes
{
    public class Task
    {
        public string command;


        private STATUS currentStatus;

        public Task(string command) {
            this.command = command;
            currentStatus = STATUS.Idle;
            Console.WriteLine("TASK STATUS: " + (int)currentStatus + "   " + currentStatus);
        }

        internal static Task<Image> Run(Func<Task<Image>> p)
        {
            throw new NotImplementedException();
        }

        public void SetStatus(STATUS newStatus)
        { 
            currentStatus = newStatus;
        
        }

        public STATUS GetStatus()
        {
            return currentStatus;
        }

        public ListViewItem ToListItem() {

            ListViewItem item = new ListViewItem(command, (int)currentStatus);

            return item;
        }

    }
}
