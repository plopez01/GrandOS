using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace GrandOS.Programs
{
    abstract class Program
    {
        internal string name;
        internal Brush color;

        protected Program(string name, Brush color)
        {
            this.name = name;
            this.color = color;
        }

        internal abstract void Execute();
    }
}
