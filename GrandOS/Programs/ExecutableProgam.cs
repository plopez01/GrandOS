using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Media;

namespace GrandOS.Programs
{
    internal class ExecutableProgam : Program
    {
        string executable;
        internal ExecutableProgam(string executable) : base(Resources.CalculatorProgram, Brushes.Orange) {
            this.executable = executable;
        }

        internal override void Execute()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = executable,
                WindowStyle = ProcessWindowStyle.Maximized,
                UseShellExecute = true
            });
        }
    }
}
