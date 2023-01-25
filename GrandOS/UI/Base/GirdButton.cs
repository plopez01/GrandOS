using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Base
{
    abstract class GirdButton
    {
        protected Rectangle background;
        protected Label content;

        protected void SetHoverEvent()
        {
            background.MouseEnter += Background_MouseEnter;
            background.MouseLeave += Background_MouseLeave;
        }

        private void Background_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Color backColor = ((SolidColorBrush)background.Fill).Color;
            backColor.A += 50;
            background.Fill = new SolidColorBrush(backColor);
            background.StrokeThickness = 0;
        }

        private void Background_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Color backColor = ((SolidColorBrush) background.Fill).Color;
            backColor.A -= 50;
            background.Fill = new SolidColorBrush(backColor);

            background.Stroke = Brushes.LightBlue;
            background.StrokeThickness = 5;
        }

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
