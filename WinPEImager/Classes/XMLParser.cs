using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPEImager.Classes;

namespace WinPEImager.Classes
{
    public class XMLParser
    {
        public XMLParser(){

        }

        public void Parse(string xmlfile) {

            


        }

        public Image parseImageFromXML(string xmlFile) {
            Console.WriteLine(xmlFile);

            List<Task> tasks = new List<Task>();


            XElement imageConfig = XElement.Load(xmlFile);
            var elements = imageConfig.Elements("TASK");
            foreach (XElement element in elements)
            {
                Console.WriteLine(element.Value);
                tasks.Add(new Task(element.Value));
            }
            //Console.WriteLine(imageConfig.Element("TASKS").Elements("TASK").First().Attribute("command").Value);
            string path = imageConfig.Element("IMAGE").Attribute("imagePath").Value;

            Console.WriteLine("Image path: " + imageConfig.Element("IMAGE").Attribute("imagePath").Value);

            Image image = new Image(path, tasks);

            return image;

        }

        
    }
}
