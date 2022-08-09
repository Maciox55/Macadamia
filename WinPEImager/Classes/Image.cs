using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPEImager.Classes;
using WinPEImager.Classes.Enums;

namespace WinPEImager.Classes
{
    public class Image
    {
        public string imagePath;
        public List<Task> tasks;

        private Task currentTask;

        private ListView listview;


        public Image(string imageLoc){
            imagePath = imageLoc;
            tasks = new List<Task>();
        }
        public Image(string imageLoc, List<Task> tasks)
        {
            imagePath = imageLoc;
            this.tasks = tasks;
        }
        public Image(string imageLoc, List<Task> tasks, ListView listView)
        {
            imagePath = imageLoc;
            this.tasks = tasks;
            listview = listView;
        }

        public void AddTask(Task newTask)
        {
            tasks.Add(newTask);
        }

        public void SetTaskStatus(int index, STATUS newStatus) 
        {
            tasks[index].SetStatus(newStatus);
        }

        public void SetList(ListView lv)
        {
            this.listview = lv;
        }

        public Task GetCurrentTask() {
            return currentTask;
        }

        public void Start()
        {
            List<Task> taskList = tasks;



            foreach (Task task in taskList)
            {
                task.Execute();
                listview.FindItemWithText(task.command).ImageIndex = ((int)task.GetStatus());
                
            }
        }
    }
}
