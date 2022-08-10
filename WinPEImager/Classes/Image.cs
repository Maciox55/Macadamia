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

        //Start executing the tasks
        public async void Start()
        {
            //temporary list, in case list manipulation will need to happen in the future (proper queue system)
            List<Task> taskList = tasks;



            foreach (Task task in taskList)
            {
                //Call execute the task
                await task.Execute();
                //change the image indes of the task in the list view
                listview.Invoke(new MethodInvoker (delegate { listview.FindItemWithText(task.command).ImageIndex = ((int)task.GetStatus()); }));
              
            }
        }
    }
}
