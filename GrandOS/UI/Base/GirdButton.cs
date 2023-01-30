using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Base
{
    abstract class GridButton : BaseButton
    {
        internal void AddToGrid(Grid grid, int x, int y)
        {
            Grid.SetColumn(background, x);
            Grid.SetRow(background, y);

            Grid.SetColumn(content, x);
            Grid.SetRow(content, y);

            grid.Children.Add(background);
            grid.Children.Add(content);
        }

        internal void ReplaceInGird(Grid grid, int x, int y)
        {
            int index = y * 2 + x;
            Grid.SetColumn(background, x);
            Grid.SetRow(background, y);

            Grid.SetColumn(content, x);
            Grid.SetRow(content, y);

            grid.Children.RemoveRange(index*2, 2);
            grid.Children.Add(background);
            grid.Children.Add(content);
        }
    }
}
