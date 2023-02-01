using GrandOS.Programs;
using GrandOS.UI.Base;
using GrandOS.UI.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Elements.Buttons
{
    internal class CloseButton
    {
        internal CloseButton(Grid grid, Window window) {

            Rectangle background = new Rectangle()
            {
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 50,
                Height = 50,
                Fill = Brushes.Red,
            };

            Label content = new Label()
            {
                IsHitTestVisible = false,
                Foreground = Brushes.White,
                Content = 'X',
                FontFamily = (FontFamily)Application.Current.Resources["settingFontFamilyContent"],
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment= VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 50,
                Height = 50,
            };

            background.MouseDown += delegate (object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                window.Close();
            };

            ButtonEffects.Darken(background);

            grid.Children.Add(background);
            grid.Children.Add(content);
        }
    }
}
