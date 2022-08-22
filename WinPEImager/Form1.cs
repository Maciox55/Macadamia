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

        MenuItem detailsManuItem = new MenuItem("Details");
        MenuItem editMenuItem = new MenuItem("Edit");
        ContextMenu mnu = new ContextMenu();

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



            mnu.MenuItems.Add(detailsManuItem);
            mnu.MenuItems.Add(editMenuItem);
            detailsManuItem.Click += new EventHandler(detailMenuItem_Click);
            editMenuItem.Click += new EventHandler(editMenuItem_Click);

            imageDetailListView.SmallImageList = new ImageList();
            imageDetailListView.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
            imageDetailListView.SmallImageList.ImageSize = new Size(24, 24);


            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/circle.png"));
            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/circle-dotted.png"));
            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/circle-check.png"));
            imageDetailListView.SmallImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/circle-x.png"));


        }

        private async Task findConfigAsync()
        {
            fileTree.Nodes.Clear();
            imageDetailListView.Clear();


            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/folders.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/folder.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/checklist.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/file-settings.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/select.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/file.png"));

            fileTree.ImageList = myImageList;

            fileTree.ImageIndex = 0;
            fileTree.SelectedImageIndex = 0;

            

            /* Set the index of image from the 
            ImageList for selected and unselected tree nodes.*/
            //this.rootImageIndex = 2;
            //this.selectedCustomerImageIndex = 3;
            //this.unselectedCustomerImageIndex = 4;
            //this.selectedOrderImageIndex = 5;
            //this.unselectedOrderImageIndex = 6;


            //Get master directory info from config that points to location of all installation files.
            DirectoryInfo dir = new DirectoryInfo(config.GetMasterPath());
            //Get all directories in the master directory
            DirectoryInfo[] dirs = dir.GetDirectories();

            TreeNode root = new TreeNode();
            //Go over the master path, each directory is at the root of the treeview
            foreach (DirectoryInfo d in dirs)
            {
                FileInfo[] files = d.GetFiles();

                if (files.Length == 0)
                {
                     fileTree.Nodes.Add(await MapDirectory(d));
                }
               
            }

           
        }

        private void clientSel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        void detailMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();

            clickedNode = null;
        }
        void editMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", clickedNode.path);
            clickedNode = null;

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

                            if (e.Node is CustomTreeNode)
                            {
                                CustomTreeNode cnode = (CustomTreeNode)e.Node;

                                //Console.WriteLine(cnode.FullPath);
                                //Parse XML at the nodes path into an image file
                                cImage image = parser.parseImageFromXML(cnode.path);
                                image.path = cnode.dirPath;
                                //Set the master path label with the path of the image file.
                                masterPathLabel.Invoke(new MethodInvoker(delegate { masterPathLabel.Text = "Image Path: " + image.path; }));
                                //Set reference to listview
                                image.SetList(imageDetailListView);
                                //Iterate over each task in image and add it to the list
                                foreach (ImageTask task in image.tasks)
                                {
                                    imageDetailListView.Invoke(new MethodInvoker(delegate { imageDetailListView.Items.Add(task.ToListItem()); }));
                                    //imageDetailListView.Items.Add(task.ToListItem());
                                }
                                //Set currently selected image
                                currentSelectedImage = image;

                            }
                        }
                    }


                    // parser.Parse(config.GetMasterPath()+e.Node.FullPath);

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
                currentSelectedImage.Start();
            }
        }

        private async Task<TreeNode> MapDirectory(DirectoryInfo path) {

            return await Task.Run(async () =>
            {
                TreeNode node = new TreeNode(path.Name);
                FileInfo[] files = path.GetFiles();

                DirectoryInfo[] subdirs = path.GetDirectories();
                foreach (DirectoryInfo subdir in subdirs)
                { 
                   node.Nodes.Add(await MapDirectory(subdir));
                }
                foreach (FileInfo file in files) {

                    if (file.Extension == ".xml")
                    {
                        node.Nodes.Add(new CustomTreeNode(file.Name, file.FullName, file.Directory.FullName, 2, 4));
                    }
                    else { 
                        node.Nodes.Add(new CustomTreeNode(file.Name,file.FullName,file.Directory.FullName,5,4));
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
            
        }
    }
}
