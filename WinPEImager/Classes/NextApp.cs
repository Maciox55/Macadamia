using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPEImager.Classes;

namespace WinPEImager.Classes
{
    public class NextApp
    {
        private string title;
        private string path;
        private string name;
        private string parameters;

        public NextApp(string appTitle, string appPath, string appName, string appParams)
        {
            title = appTitle;
            path = appPath;
            name = appName;
            parameters = appParams;
        }
        public string GetName()
        {
            return title;
        }
        public string GetPath()
        {
            return path + name;
        }

        public string GetParams()
        {
            return parameters;
        }

        public void Run()
        {
            if (GetParams() == String.Empty)
            {
                CMDR.GetProcess().RunApp(GetPath(), GetParams());
            }
            else
            {
                CMDR.GetProcess().RunApp(GetPath());
            }

        }
    }
}
