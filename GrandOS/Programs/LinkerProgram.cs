using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using GrandOS.Programs.Base;

namespace GrandOS.Programs
{
    internal class LinkerProgram : Program
    {
        private string url;
        internal LinkerProgram(string url) : base(Resources.MailProgram, Brushes.BlueViolet, null) {
            this.url = url;
        }

        internal override void Execute()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
