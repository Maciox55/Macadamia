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
using Image = WinPEImager.Classes.Image;

namespace WinPEImager
{
    public partial class Form1 : Form
    {
        private Config config;
        public XMLParser parser = new XMLParser();
        public List<Client> clients = new List<Client>();

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
            DirectoryInfo dir = new DirectoryInfo(config.GetMasterPath());
            DirectoryInfo[] dirs = dir.GetDirectories();

            //Console.WriteLine(files.Length);
            //string text = File.ReadAllText(files[0].FullName);

            foreach (DirectoryInfo d in dirs){
                TreeNode node = new TreeNode(d.Name);
                DirectoryInfo[] subDir = d.GetDirectories();
                Client client = new Client(d.Name);
               
                foreach (DirectoryInfo sd in subDir) {
                    TreeNode subNode = new TreeNode(sd.Name);
                    node.Nodes.Add(subNode);
                    FileInfo[] files = sd.GetFiles("*.xml");

                    foreach (FileInfo file in files)
                    {
                        client.AddImage(new Image(file.FullName));
                        TreeNode n = new TreeNode(file.Name);
                        subNode.Nodes.Add(n);
                    }


                }
                clients.Add(client);


                clientSel.Items.Add(d.Name);

                fileTree.Nodes.Add(node);
            }

            foreach (Client client in clients)
            {
                Console.WriteLine(client.name);
                imageDetailListView.Groups.Add(new ListViewGroup("Client", client.name));
                imageDetailListView.ShowGroups =  true; 

                foreach (Image image in client.GetImages()) {
                    imageDetailListView.Items.Add(image.imagePath);


                }

            }

            string text = File.ReadAllText(Path.Combine(config.GetMasterPath(), "test.txt"));
            Console.WriteLine(text);
        }

        private void clientSel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void fileTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.NextNode == null)
            {
                parser.Parse(config.GetMasterPath()+e.Node.FullPath);

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            findConfig();
        }
    }
}
