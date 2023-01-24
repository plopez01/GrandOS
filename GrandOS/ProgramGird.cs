using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GrandOS
{
    class ProgramGird
    {
        int horizontalMargin, verticalMargin;
        List<Program> programs;

        public ProgramGird(Grid gird, int horizontalMargin, int verticalMargin)
        {
            programs = new List<Program>();
        }
    }
}
