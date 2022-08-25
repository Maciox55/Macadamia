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
        private string nextAppPath;
        private string nextAppText;
        private string nextApp;
        private string nextAppParams;

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

        public string GetNextAppPath() {
            return nextAppPath;
        }

        public string GetNextAppName() {
            return nextAppText;
        }

        public string GetNextApp() {
            return nextApp;
        
        }
        public string GetNextAppParams()
        {
            return nextAppParams;

        }


        private void ParseConfigFile(XElement xmlContent) {
            masterPath = xmlContent.Element("MASTERPATH").Value;
            workingdrive = xmlContent.Element("WORKINGDRIVE").Value;

            if (xmlContent.Element("NEXTAPP") != null)
            {
                nextAppPath = xmlContent.Element("NEXTAPP").Attribute("path").Value;
                nextAppText = xmlContent.Element("NEXTAPP").Attribute("name").Value;
                nextApp = xmlContent.Element("NEXTAPP").Attribute("appName").Value;
                nextAppParams = xmlContent.Element("NEXTAPP").Attribute("appParams").Value;
            }

            
            Console.WriteLine(masterPath);

        }
    }
}
