using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPEImager.Classes;
using WinPEImager.Classes.Interfaces;
using System.Windows.Forms;

namespace WinPEImager.Classes
{
    internal class ScriptNode : CustomTreeNode, IListable
    {
        private Image image;
        public ScriptNode(string text)
        {
            Text = text;

        }
        public ScriptNode(string text, string path)
        {
            Text = text;
            this.path = path;
            this.image = XMLParser.GetInstance().parseImageFromXML(this.path);

        }
        public ScriptNode(string text, string path, string dir, int imageIndex, int selectionImageIndex)
        {
            Text = text;
            this.path = path;
            dirPath = dir;
            ImageIndex = imageIndex;
            SelectedImageIndex = selectionImageIndex;
            this.image = XMLParser.GetInstance().parseImageFromXML(this.path);

        }
        public ScriptNode(string text, int imageIndex, int selectionImageIndex)
        {
            Text = text;
            ImageIndex = imageIndex;
            SelectedImageIndex = selectionImageIndex;

        }

        public ListView TasksToList() { 

            return image.toli
        
        }



    }
}
