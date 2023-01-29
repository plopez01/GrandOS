using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Base
{
    abstract class GridButton : ButtonBase
    {
        protected void AddToGrid(Grid grid, int x, int y)
        {
            Grid.SetColumn(background, x);
            Grid.SetRow(background, y);

            Grid.SetColumn(content, x);
            Grid.SetRow(content, y);

            grid.Children.Add(background);
            grid.Children.Add(content);
        }
    }
}
