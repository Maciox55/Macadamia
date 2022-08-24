using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPEImager.Classes
{
    internal class ScriptNode : CustomTreeNode
    {
        public Image image;
        public ScriptNode(string text, string path, string dir, Image i, int imageIndex, int selectionImageIndex)
        {
            Text = text;
            this.path = path;
            dirPath = dir;
            this.image = i;
            ImageIndex = imageIndex;
            SelectedImageIndex = selectionImageIndex;


        }
    }
}
