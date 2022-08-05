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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public Form1()
        {
            InitializeComponent();
            config = Config.Instance();
            findConfig();
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

            //Console.WriteLine(files.Length);
            //string text = File.ReadAllText(files[0].FullName);

            //TODO: make this recursive for better dynamic parsing

            //Goes through each directory and map contents
            foreach (DirectoryInfo d in dirs){
                TreeNode node = new TreeNode(d.Name);
                DirectoryInfo[] subDir = d.GetDirectories();
                Client client = new Client(d.Name);
               
                //Get all partnumber subfolders for each mfg
                foreach (DirectoryInfo sd in subDir) {
                    TreeNode subNode = new TreeNode(sd.Name,1,1);
                    node.Nodes.Add(subNode);
                    FileInfo[] files = sd.GetFiles("*.xml");
                    //Get all of the files within the partnumber folder
                    foreach (FileInfo file in files)
                    {
                        client.AddImage(new cImage(file.FullName));
                        CustomTreeNode n = new CustomTreeNode(file.Name,file.FullName,2,4);
                        subNode.Nodes.Add(n);
                    }


                }
                clients.Add(client);


                clientSel.Items.Add(d.Name);

                fileTree.Nodes.Add(node);
            }


            string text = File.ReadAllText(Path.Combine(config.GetMasterPath(), "test.txt"));
            Console.WriteLine(text);
        }

        private void clientSel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void fileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node is CustomTreeNode)
            {
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
                Console.WriteLine(cnode.path);
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
    }
}
