using GrandOS.Programs;
using GrandOS.UI.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Elements
{
    internal class ProgramButton : GridButton
    {
        internal ProgramButton(Program program, Grid grid, int x, int y, Thickness margin)
        {
            background = new Rectangle()
            {
                Margin = margin,
                Fill = program.color,
            };

            content = new Label()
            {
                IsHitTestVisible = false,
                Foreground = Brushes.White,
                Content = program.name,
                FontFamily = (FontFamily)Application.Current.Resources["settingFontFamilyContent"],
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };

            background.MouseDown += delegate(object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                program.Execute();
            };

            background.MouseEnter += MouseEnter;
            background.MouseLeave += MouseLeave;

            AddToGrid(grid, x, y);
        }

        protected void MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Color backColor = ((SolidColorBrush)background.Fill).Color;
            backColor.A -= 50;
            background.Fill = new SolidColorBrush(backColor);

            background.Stroke = Brushes.LightBlue;
            background.StrokeThickness = 5;
        }

        protected void MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Color backColor = ((SolidColorBrush)background.Fill).Color;
            backColor.A += 50;
            background.Fill = new SolidColorBrush(backColor);
            background.StrokeThickness = 0;
        }
    }
}
