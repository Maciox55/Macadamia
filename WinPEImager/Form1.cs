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
using WinPEImager.Classes;
using cImage = WinPEImager.Classes.Image;
using Image = System.Drawing.Image;

namespace WinPEImager
{
    public partial class Form1 : Form
    {
        private Config config;
        public XMLParser parser = new XMLParser();
        public List<Client> clients = new List<Client>();

        string clickedNode;

        MenuItem myMenuItem = new MenuItem("Show Me");
        ContextMenu mnu = new ContextMenu();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        public Form1()
        {
            InitializeComponent();
            config = Config.Instance();
            findConfig();



            mnu.MenuItems.Add(myMenuItem);
            myMenuItem.Click += new EventHandler(myMenuItem_Click);
        }

        private void findConfig()
        {
            fileTree.Nodes.Clear();
            clientSel.Items.Clear();
            imageDetailListView.Clear();


            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/folders.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/folder.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/file.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/file-settings.png"));
            myImageList.Images.Add(Image.FromFile("./Assets/Images/icons-png/select.png"));

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
                    fileTree.Nodes.Add(MapDirectory(d));
                }
               
            }

           
        }

        private void clientSel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        void myMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = clickedNode;
            frm.ShowDialog(this);
            clickedNode = "";
        }


        private void fileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
           

            if (e.Node is CustomTreeNode)
            {

                if (e.Button == MouseButtons.Right)
                {
                    clickedNode = e.Node.Name;
                    mnu.Show(fileTree, e.Location);
                }

                CustomTreeNode cnode = (CustomTreeNode)e.Node;
                Console.WriteLine(cnode.path);
                // parser.Parse(config.GetMasterPath()+e.Node.FullPath);

            }

        }

        private void fileTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is CustomTreeNode)
            {
                CustomTreeNode cnode = (CustomTreeNode)e.Node;
                Console.WriteLine(cnode.FullPath);
                cImage image = parser.parseImageFromXML(cnode.path);

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            findConfig();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private TreeNode MapDirectory(DirectoryInfo path) { 
            TreeNode node = new TreeNode(path.Name);
            FileInfo[] files = path.GetFiles("*.xml");

            DirectoryInfo[] subdirs = path.GetDirectories();
            foreach (DirectoryInfo subdir in subdirs)
            { 
               node.Nodes.Add( MapDirectory(subdir));
            }
            foreach (FileInfo file in files) {
                node.Nodes.Add(new CustomTreeNode(file.Name,file.FullName,2,4));
            }

            return node;
        
        }
    }
}
