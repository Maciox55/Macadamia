using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPEImager.Classes;
using WinPEImager.Classes.Enums;
using System.IO;
using System.Text.RegularExpressions;

namespace WinPEImager.Classes
{
    public class Image : TreeNode
    {
        public string path;
        public string imagePath;
        public List<Task> tasks;


        private ListView listview;

        public Image(string imageLoc){
            imagePath = imageLoc;
           
        }
        public Image(string imageLoc, List<Task> tasks)
        {
            imagePath = imageLoc;
            this.tasks = ReplacePath(tasks);
        }
        public Image(string imageLoc, List<Task> tasks, ListView listView)
        {
            imagePath = imageLoc;
            this.tasks = ReplacePath(tasks);
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

            CopyDirectory(path + @"\Required\", Config.Instance().GetWorkingDir() + @"\Required\", true);



            foreach (Task task in taskList)
            {
                //Call execute the task
                await task.Execute();
                //change the image indes of the task in the list view
                listview.Invoke(new MethodInvoker(delegate { listview.FindItemWithText(task.command).ImageIndex = ((int)task.GetStatus()); }));

            }
        }

        private List<Task> ReplacePath(List<Task> originalTasks) {

            List<Task> replacedTasks = new List<Task>();
            foreach (Task task in originalTasks)
            {
                task.command = Regex.Replace(task.command, "{{imagePath}}", this.imagePath);

                replacedTasks.Add(task);
            }

            return replacedTasks;
        
        }


        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath,true);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
            Console.WriteLine("Files Copied");
        }
    }
}