using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPEImager.Classes;
using Image = WinPEImager.Classes.Image;

namespace WinPEImager.Forms
{
    public partial class Details : Form
    {


        public CustomTreeNode node;
        public Details(Image image)
        {
            imageDetailTaskList.Items = image.ToListDynamic();
            InitializeComponent();



        }
    }
}
