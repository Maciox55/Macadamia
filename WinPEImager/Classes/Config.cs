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

        private void ParseConfigFile(XElement xmlContent) {
            masterPath = xmlContent.Element("MASTERPATH").Value;
            Console.WriteLine(masterPath);
            
        }
    }
}
