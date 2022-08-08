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
            try
            {
                List<Task> tasks = new List<Task>();
                XDocument xdoc;

                xdoc = XDocument.Load(xmlFile);
                //TODO: Potentially make it more dynamic, for now its hard coded for testing purposes.
                string imagePath = xdoc.Root.Element("IMAGE").Attribute("imagePath").Value;

                IEnumerable<XElement> elements = xdoc.Root.Element("TASKS").Elements("TASK");
                Console.WriteLine("TEST " + xdoc.Root.Element("TASKS").Elements("TASK").ToList().Count);

                foreach (XElement element in elements)
                {
                    Console.WriteLine(element.Attribute("command").Value);
                    tasks.Add(new Task(element.Attribute("command").Value));
                }

                Image image = new Image(imagePath, tasks);

                return image;

            }
            catch(Exception e) {
                throw e;
            }
        }

        
    }
}
