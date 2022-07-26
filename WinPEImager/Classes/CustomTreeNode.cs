﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WinPEImager.Classes
{
    public class CustomTreeNode : TreeNode
    {
        public string path;
        public string dirPath;


        public CustomTreeNode() { }

        public CustomTreeNode(string text)
        {
            Text = text;

        }
        public CustomTreeNode(string text, string path)
        {
            Text = text;
            this.path = path;

        }
        public CustomTreeNode(string text, string path, string dir, int imageIndex, int selectionImageIndex)
        {
            Text = text;
            this.path = path;
            dirPath = dir;
            ImageIndex = imageIndex;
            SelectedImageIndex = selectionImageIndex;

        }

        public CustomTreeNode(string text, int imageIndex, int selectionImageIndex)
        {
            Text = text;
            ImageIndex = imageIndex;
            SelectedImageIndex = selectionImageIndex;

        }

    }
}
