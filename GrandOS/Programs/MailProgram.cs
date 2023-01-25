using System;
using System.Collections.Generic;
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
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            //Application.Current.Shutdown();
        }
    }
}
