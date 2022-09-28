using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPEImager.Classes
{
    public class CustomListViewItem : ListViewItem
    {
        public Task task;
        public CustomListViewItem(string text, int imageIndex,Task t)
        {
            this.Text = text;
            this.ImageIndex = imageIndex;
            this.task = t;
        }


    }
}
