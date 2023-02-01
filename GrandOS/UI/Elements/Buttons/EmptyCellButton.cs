using GrandOS.Programs;
using GrandOS.UI.Base;
using GrandOS.UI.Static;
using GrandOS.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Elements.Buttons
{
    // This could be a program instead of it's own separate class
    internal class EmptyCellButton : GridButton
    {
        internal EmptyCellButton(ProgramGrid programGrid, int x, int y, Thickness margin)
        {
            Rectangle background = new Rectangle()
            {
                Margin = margin,
                Fill = Brushes.DimGray,
            };

            Label content = new Label()
            {
                IsHitTestVisible = false,
                Foreground = Brushes.White,
                Content = "+",
                FontFamily = (FontFamily)Application.Current.Resources["settingFontFamilyContent"],
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };

            background.MouseDown += delegate (object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                AddProgramPopup popup = new AddProgramPopup(programGrid, x, y);
                popup.Show();
            };

            ButtonEffects.Darken(background);

            grid.Children.Add(background);
            grid.Children.Add(content);
        }
    }
}
