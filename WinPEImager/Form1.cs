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


namespace WinPEImager
{
    public partial class Form1 : Form
    {
        private Config config;
        public Form1()
        {
            InitializeComponent();
            config = Config.Instance();
            findConfig();
        }

        private void findConfig()
        {

            DirectoryInfo dir = new DirectoryInfo(Config.Instance().GetMasterPath());
            DirectoryInfo[] dirs = dir.GetDirectories();

            //Console.WriteLine(files.Length);
            //string text = File.ReadAllText(files[0].FullName);

            foreach (DirectoryInfo d in dirs){
                TreeNode node = new TreeNode(d.Name);

                FileInfo[] files = d.GetFiles("*.xml");
                clientSel.Items.Add(d.Name);

                fileTree.Nodes.Add(node);
            }



            string text = File.ReadAllText(Path.Combine(Config.Instance().GetMasterPath(), "test.txt"));
            Console.WriteLine(text);
        }

        private void clientSel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
