using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GrandOS.UI.Base
{
    internal abstract class StackButtonBase
    {
        protected Grid grid = new Grid();

        internal void AddToStackPanel(StackPanel stackPanel)
        {
            stackPanel.Children.Add(grid);
        }
    }
}
