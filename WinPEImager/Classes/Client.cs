using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPEImager.Classes
{
    public class Client
    {
        public string name;
        private List<Image> images;

        public Client(string clientName)
        {
            name = clientName;
            images = new List<Image>();
        }

        public void AddImage(Image newImage)
        { 
            images.Add(newImage);
        }
        public List<Image> GetImages() {
            return images;
        }
    }
}
