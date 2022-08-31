using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace WinPEImager.Classes
{
    //TODO: Make a singleton later
    public sealed class Config
    {
        private static readonly Config instance = new Config();
        private string masterPath;
        private string workingdrive;

        //TODO: Make Next App a separate Class later, for potantial chaining, ease of use, etc.
        //private string nextAppPath;
        //private string nextAppText;
        //private string nextAppName;
        //private string nextAppParams;

        private NextApp nextApp;

        private Config() {
            Console.WriteLine("Initialized Config Singleton");
            string text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.xml"));
            XElement configstring = XElement.Load(@"Config.xml");
            ParseConfigFile(configstring);
            
        }

        public static Config Instance() {
            return instance;
        }

        public string GetMasterPath() {
            return masterPath;
        }

        public string GetWorkingDir() {
            return workingdrive;
        }

        public NextApp GetNextApp() {
            return nextApp;
        }

        //public string GetNextAppPath() {
        //    return nextAppPath;
        //}

        //public string GetNextAppName() {
        //    return nextAppText;
        //}

        //public string GetNextApp() {
        //    return nextAppName;
        
        //}
        //public string GetNextAppParams()
        //{
        //    return nextAppParams;

        //}


        private void ParseConfigFile(XElement xmlContent) {
            try
            {
                masterPath = xmlContent.Element("MASTERPATH").Value;
                workingdrive = xmlContent.Element("WORKINGDRIVE").Value;

                if (xmlContent.Element("NEXTAPP") != null)
                {
                    string nextAppPath = xmlContent.Element("NEXTAPP").Attribute("path").Value;
                    string nextAppText = xmlContent.Element("NEXTAPP").Attribute("name").Value;
                    string nextAppName = xmlContent.Element("NEXTAPP").Attribute("appName").Value;
                    string nextAppParams = xmlContent.Element("NEXTAPP").Attribute("appParams").Value;
                    nextApp = new NextApp(nextAppText, nextAppPath, nextAppName, nextAppParams);
                }


                Console.WriteLine(masterPath);
            }
            catch (Exception e)
            {
                CMDR.GetProcess().WriteToConsole("Error parsing Config file!");
                CMDR.GetProcess().WriteToConsole(e.Message);
            }
        }
    }
}
