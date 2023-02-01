using GrandOS.Programs.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

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
            int index = y * grid.ColumnDefinitions.Count + x;
            Grid.SetColumn(localGrid, x);
            Grid.SetRow(localGrid, y);

            UIElement cell = grid.Children
              .Cast<UIElement>()
              .First(e => Grid.GetRow(e) == y && Grid.GetColumn(e) == x);

            grid.Children.Remove(cell);
            grid.Children.Add(localGrid);
        }
    }
}
