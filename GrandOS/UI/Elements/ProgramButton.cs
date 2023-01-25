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
    internal class ProgramButton : GirdButton
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
                Foreground = Brushes.White,
                Content = program.name,
                FontFamily = (FontFamily)Application.Current.Resources["settingFontFamilyContent"],
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };

            AddToGrid(grid, x, y);
        }
    }
}
