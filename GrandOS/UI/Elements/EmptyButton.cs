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
    // This could be a program instead of it's own separate class
    internal class EmptyButton : GirdButton
    {
        internal EmptyButton(Grid grid, int x, int y, Thickness margin)
        {
            background = new Rectangle()
            {
                Margin = margin,
                Fill = Brushes.DimGray,
                IsHitTestVisible = false
            };

            content = new Label()
            {
                IsHitTestVisible = false,
                Foreground = Brushes.White,
                Content = "+",
                FontFamily = (FontFamily) Application.Current.Resources["settingFontFamilyContent"],
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };

            background.MouseDown += delegate (object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                
            };

            AddToGrid(grid, x, y);
        }
    }
}
