using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPEImager.Classes;
using WinPEImager.Classes.Enums;

namespace WinPEImager.Classes
{
    public class XMLParser
    {
        public XMLParser()
        {

        }

        public void Parse(string xmlfile)
        {

        }

        public Image parseImageFromXML(string xmlFile)
        {
            try
            {
                List<Task> tasks = new List<Task>();
                XDocument xdoc;

                xdoc = XDocument.Load(xmlFile);
                //TODO: Potentially make it more dynamic, for now its hard coded for testing purposes.
                string imagePath = xdoc.Root.Element("IMAGE").Attribute("imagePath").Value;

                IEnumerable<XElement> elements = xdoc.Root.Element("TASKS").Elements("TASK");

                Image image = new Image(imagePath);
                foreach (XElement element in elements)
                {
                    string type = element.Attribute("type").Value.ToLower();
                    if (type == "command")
                    {
                        tasks.Add(new Task(element.Attribute("command").Value,image, TYPE.Command));
                    }
                    else if (type == "bat")
                    {
                        tasks.Add(new Task(element.Attribute("command").Value,image, TYPE.Bat));
                    }
                    else if (type == "next")
                    {
                        tasks.Add(new Task(TYPE.Next,image));
                    }
                }

                image.SetTasks(tasks);

                return image;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
