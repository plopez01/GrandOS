using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace GrandOS.Programs
{
    internal class MailProgram : Program
    {
        internal MailProgram() : base(Resources.MailProgram, Brushes.BlueViolet) { }

        internal override void Execute()
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.gmail.com",
                UseShellExecute = true
            });
        }
    }
}
