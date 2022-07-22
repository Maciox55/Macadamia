using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPEImager.Classes;

namespace WinPEImager.Classes
{
    public class Image
    {
        public string imagePath;
        public List<Task> tasks;

        public Image(string imageLoc){
            imagePath = imageLoc;
            tasks = new List<Task>();
        }

        public void AddTask(Task newTask)
        {
            tasks.Add(newTask);
        }
    }
}
