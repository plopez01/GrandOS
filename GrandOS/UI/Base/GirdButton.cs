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
        protected Grid localGrid = new Grid();

        internal void AddToGrid(Grid grid, int x, int y)
        {
            Grid.SetColumn(localGrid, x);
            Grid.SetRow(localGrid, y);

            grid.Children.Add(localGrid);
        }

        internal void ReplaceInGird(Grid grid, int x, int y)
        {
            int index = y * 2 + x;
            Grid.SetColumn(localGrid, x);
            Grid.SetRow(localGrid, y);

            grid.Children.RemoveAt(index);
            grid.Children.Add(localGrid);
        }
    }
}
