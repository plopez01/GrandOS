using GrandOS.Programs.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GrandOS.Programs
{
    internal class ExternalProgram : Program
    {
        string appUserModelID;

        public ExternalProgram(string name, string appUserModelID, Brush color, ImageSource icon) : base(name, color, icon)
        {
            this.appUserModelID = appUserModelID;
        }

        internal override void Execute()
        {
            Process.Start("explorer.exe", @" shell:appsFolder\" + appUserModelID);
        }
    }
}
