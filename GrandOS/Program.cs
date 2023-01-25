using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace GrandOS
{
    class Program
    {
        public string name;
        public Brush color;

        public Program(string name, Brush color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
