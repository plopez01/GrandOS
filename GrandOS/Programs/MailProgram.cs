using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace GrandOS.Programs
{
    internal class MailProgram : Program
    {
        internal MailProgram() : base("Mail", Brushes.BlueViolet) { }

        internal override void Execute()
        {
            Application.Current.Shutdown();
        }
    }
}
