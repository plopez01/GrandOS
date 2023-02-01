using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Base
{
    abstract class GridButton
    {
        protected Grid grid = new Grid();

        internal void AddToGrid(Grid grid, int x, int y)
        {
            Grid.SetColumn(grid, x);
            Grid.SetRow(grid, y);

            grid.Children.Add(grid);
        }

        internal void ReplaceInGird(Grid grid, int x, int y)
        {
            int index = y * 2 + x;
            Grid.SetColumn(grid, x);
            Grid.SetRow(grid, y);


            grid.Children.RemoveRange(index*2, 2);
            grid.Children.Add(grid);
        }
    }
}
