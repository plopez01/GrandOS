using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Media;
using GrandOS.Programs.Base;

namespace GrandOS.Programs
{
    internal class ExecutableProgam : Program
    {
        string executable;
        internal ExecutableProgam(string executable) : base(Resources.CalculatorProgram, Brushes.Orange, null) {
            this.executable = executable;
        }

        internal override void Execute()
        {
            Process proc = Process.Start(new ProcessStartInfo
            {
                FileName = executable,
                WindowStyle = ProcessWindowStyle.Maximized,
                UseShellExecute = true
            });
        }
    }
}
