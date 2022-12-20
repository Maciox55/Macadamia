using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;
using WinPEImager.Classes;
using WinPEImager.Forms;
using cImage = WinPEImager.Classes.Image;
using ImageTask = WinPEImager.Classes.Task;
using Image = System.Drawing.Image;
using Task = System.Threading.Tasks.Task;

namespace WinPEImager
{
    public partial class Form1 : Form
    {
        private Config config;
        public XMLParser parser = new XMLParser();
        public List<Client> clients = new List<Client>();
        cImage currentSelectedImage;

        CustomTreeNode clickedNode;

        CustomListViewItem selectedTask;

        MenuItem detailsMenuItem = new MenuItem("Details");
        MenuItem editMenuItem = new MenuItem("Edit");
        ContextMenu mnu = new ContextMenu();

        ContextMenu taskMenu = new ContextMenu();
        MenuItem runTaskItem = new MenuItem("Run");


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;
        }

        public Form1()
        {
            InitializeComponent();
            config = Config.Instance();
            CMDR.GetProcess().SetConsoleOutput(consoleOutputTextBox);
            findConfigAsync();

            if (config.GetNextApp().GetPath() != null && config.GetNextApp().GetParams() != null && config.GetNextApp().GetName() != null)
            {
                ToolStripMenuItem nextAppMenuItem = new ToolStripMenuItem(config.GetNextApp().GetName());
                nextAppMenuItem.Click += new EventHandler(nextAppMenuItem_Click);
                menuStrip.Items.Add(nextAppMenuItem);
            }


            taskMenu.MenuItems.Add(runTaskItem);

            runTaskItem.Click += new EventHandler(runTaskItem_Click);

            //mnu.MenuItems.Add(detailsMenuItem);
            mnu.MenuItems.Add(editMenuItem);
            detailsMenuItem.Click += new EventHandler(detailMenuItem_Click);
            editMenuItem.Click += new EventHandler(editMenuItem_Click);

            imageDetailListView.SmallImageList = new ImageList();
            imageDetailListView.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
            imageDetailListView.SmallImageList.ImageSize = new Size(24, 24);

            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/circle_32x32.png"));
            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/circle-dotted_32x32.png"));
            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/circle-check_32x32.png"));
            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/circle-x_32x32.png"));

        }

        private void NextAppMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async Task findConfigAsync()
        {
            fileTree.Nodes.Clear();
            imageDetailListView.Clear();


            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/folders_16x16.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/folder_16x16.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/checklist_16x16.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/file-settings_16x16.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/select_16x16.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/file_16x16.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/Resized/app-window_16x16.png"));

            fileTree.ImageList = myImageList;

            fileTree.ImageIndex = 0;
            fileTree.SelectedImageIndex = 0;

            //Get master directory info from config that points to location of all installation files.
            DirectoryInfo dir = new DirectoryInfo(config.GetMasterPath());
            //Get all directories in the master directory
            DirectoryInfo[] dirs = dir.GetDirectories();

            TreeNode root = new TreeNode();
            //Go over the master path, each directory is at the root of the treeview
            foreach (DirectoryInfo d in dirs)
            {
                FileInfo[] files = d.GetFiles();
                fileTree.Nodes.Add(await MapDirectory(d));
            }
        }

        private void clientSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void detailMenuItem_Click(object sender, EventArgs e)
        {
            Details detailsForm = new Details();
            detailsForm.node = clickedNode;
            detailsForm.Show();
            clickedNode = null;
        }
        void editMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", clickedNode.path);
            clickedNode = null;

        }

        void taskRun_click(object sender, EventArgs e)
        {

        }


        void nextAppMenuItem_Click(object sender, EventArgs e)
        {
           
            config.GetNextApp().Run();
            
        }

        private async void fileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            await Task.Run(async () =>
             {

                //masterPathLabel.Invoke(new MethodInvoker(delegate { masterPathLabel.Text = "Image Path: " + e.Node.FullPath; }));
                fileTree.Invoke(new MethodInvoker(delegate { fileTree.SelectedNode = e.Node; }));
                //fileTree.SelectedNode = e.Node;
                try
                 {
                     if (e.Node is CustomTreeNode)
                     {

                         if (e.Button == MouseButtons.Right)
                         {

                             clickedNode = (CustomTreeNode)e.Node;

                             this.Invoke(new MethodInvoker(delegate
                             {
                                 mnu.Show(fileTree, e.Location);
                             }));

                         }
                         else {

                             imageDetailListView.Invoke(new MethodInvoker(delegate { imageDetailListView.Clear(); }));

                             if (e.Node is ScriptNode)
                             {
                                 ScriptNode cnode = (ScriptNode)e.Node;
                                 startButton.Invoke(new MethodInvoker(delegate { startButton.Text = "START"; }));
                                 //Console.WriteLine(cnode.FullPath);
                                 //Parse XML at the nodes path into an image file
                                 //cImage image = parser.parseImageFromXML(cnode.path);
                                 cnode.image.path = cnode.dirPath;
                                //Set the master path label with the path of the image file.
                                masterPathLabel.Invoke(new MethodInvoker(delegate { masterPathLabel.Text = "Script Path: " + cnode.dirPath; }));
                                //Set reference to listview
                                cnode.image.SetList(imageDetailListView);
                                cnode.image.ToList();
                                 cnode.image.SetForm(this);
                                currentSelectedImage = cnode.image;

                             }
                         }
                     }
                }
                 catch (Exception ex)
                 {
                     MessageBox.Show("ERROR OCCURED: " + ex.Message);

                 }
             });
        }

        private void fileTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node is CustomTreeNode)
                {


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR OCCURED: " + ex.Message);

            }

        }


        private async void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedTask = null;
                taskSelectionLabel.Text = "No Task Selected";
                startButton.Text = "START";
                await findConfigAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR OCCURED: " + ex.Message);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (currentSelectedImage != null)
            {
                if (currentSelectedImage.canStart == false )
                {
                    
                    currentSelectedImage.canStart = true;
                    currentSelectedImage.Start();
                    startButton.Text = "STOP";

                }
                else {
                    currentSelectedImage.canStart = false;
                    currentSelectedImage.Kill();
                    startButton.Text = "START";
                }

            }
            else {
                MessageBox.Show("Please select a task config file first.");
            }
        }

        private async Task<TreeNode> MapDirectory(DirectoryInfo path) {

            return await Task.Run(async () =>
            {
                TreeNode node = new TreeNode(path.Name);
                FileInfo[] files = path.GetFiles();

                DirectoryInfo[] subdirs = path.GetDirectories();
                if (path.GetDirectories().Length == 0)
                {
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                }


                foreach (DirectoryInfo subdir in subdirs)
                {
                    node.Nodes.Add(await MapDirectory(subdir));
                }
                foreach (FileInfo file in files) {

                    if (file.Extension == ".xml")
                    {
                        node.Nodes.Add(new ScriptNode(file.Name, file.FullName, file.Directory.FullName, parser.parseImageFromXML(file.FullName), 2, 4));
                        
                    }
                    else if (file.Extension == ".txt" || file.Extension == ".bat" || file.Extension == ".cmd")
                    {
                        node.Nodes.Add(new CustomTreeNode(file.Name, file.FullName, file.Directory.FullName, 5, 4));
                    }
                    else if (file.Extension == ".exe")
                    {
                        node.Nodes.Add(new TreeNode(file.Name, 6, 4));
                    }
                }

                return node;
            });
        }

        private void imageDetailListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void consoleClearButton_Click(object sender, EventArgs e)
        {
            consoleOutputTextBox.Clear();
        }

        private void fileBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmdInputSubmitButton_Click(object sender, EventArgs e)
        {
            CMDR.GetProcess().Write(cmdInputField.Text);
            cmdInputField.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WorkingDirectory = @"C:";
            proc.Start();
        }

        private void abortCMD_Click(object sender, EventArgs e)
        {
            currentSelectedImage.canStart = false;
            CMDR.GetProcess().Abort();
        }

        private void imageDetailListView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = imageDetailListView.SelectedItems[0];
                selectedTask = (CustomListViewItem)item;
                Console.WriteLine(selectedTask.task.command);

                taskSelectionLabel.Text = "Task: " + selectedTask.task.command;

                if (e.Button == MouseButtons.Right)
                {
                    if (item != null && item.Bounds.Contains(e.Location))
                    {
                        taskMenu.Show(imageDetailListView, e.Location);
                    }
                }
            }
            catch {

                selectedTask = null;
                taskSelectionLabel.Text = "No Selected Task";
            }
            
        }

        private async void runTaskItem_Click(object sender, EventArgs e)
        {
            if (selectedTask != null)
            { 
                selectedTask.task.GetParentImage().StartOne(selectedTask.task);
            }
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdInputSubmitButton.PerformClick();
                cmdInputField.Text = "";
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}