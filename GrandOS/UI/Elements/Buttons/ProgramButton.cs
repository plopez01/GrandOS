using GrandOS.Programs.Base;
using GrandOS.UI.Base;
using GrandOS.UI.Static;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Elements.Buttons
{
    internal class ProgramButton : GridButton
    {
        internal ProgramButton(Program program, Thickness margin)
        {
            Rectangle background = new Rectangle()
            {
                Margin = margin,
                Fill = program.color,
            };

            Label content = new Label()
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

            background.MouseDown += delegate (object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                program.Execute();
            };

            ButtonEffects.Darken(background);
            ButtonEffects.Stroke(background, Brushes.LightBlue);

            grid.Children.Add(background);
            grid.Children.Add(content);
        }
    }
}
