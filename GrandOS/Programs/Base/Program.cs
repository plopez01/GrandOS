using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace GrandOS.Programs.Base
{
    public abstract class Program
    {
        internal string name;
        internal Brush color;
        internal ImageSource icon;

        protected Program(string name, Brush color, ImageSource icon)
        {
            this.name = name;
            this.color = color;
            this.icon = icon;
        }

        internal abstract void Execute();
    }
}
