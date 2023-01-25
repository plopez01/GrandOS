using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Media;

namespace GrandOS.Programs
{
    internal class CalculatorProgram : Program
    {
        internal CalculatorProgram() : base(Resources.CalculatorProgram, Brushes.Orange) { }

        internal override void Execute()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "Start-Process calc -WindowStyle ([System.Diagnostics.ProcessWindowStyle]::Maximized)",
                UseShellExecute = true
            });
        }
    }
}
