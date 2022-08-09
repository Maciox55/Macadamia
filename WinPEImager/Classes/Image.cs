using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPEImager.Classes;
using WinPEImager.Classes.Enums;

namespace WinPEImager.Classes
{
    public class Image
    {
        public string imagePath;
        public List<Task> tasks;

        private Task currentTask;


        public Image(string imageLoc){
            imagePath = imageLoc;
            tasks = new List<Task>();
        }
        public Image(string imageLoc, List<Task> tasks)
        {
            imagePath = imageLoc;
            this.tasks = tasks;
        }

        public void AddTask(Task newTask)
        {
            tasks.Add(newTask);
        }

        public void SetTaskStatus(int index, STATUS newStatus) 
        {
            tasks[index].SetStatus(newStatus);
        }

        public Task GetCurrentTask() {
            return currentTask;
        }

        public void Start()
        {
            foreach (Task task in tasks)
            {
               


            }
        }
    }
}
