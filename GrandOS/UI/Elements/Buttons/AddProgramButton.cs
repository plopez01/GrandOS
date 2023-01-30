using GrandOS.Programs;
using GrandOS.UI.Base;
using GrandOS.UI.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace GrandOS.UI.Elements.Buttons
{
    internal class AddProgramButton : StackButtonBase
    {
        public delegate void ProgramSelectedEventHandler(object source);
        public event ProgramSelectedEventHandler ProgramSelected;
        internal AddProgramButton(StackPanel stackPanel, ExternalProgram extProgram, Thickness margin)
        {
            Rectangle background = new Rectangle()
            {
                Margin = margin,
                Fill = extProgram.color,
            };

            Label content = new Label()
            {
                IsHitTestVisible = false,
                Foreground = Brushes.White,
                Content = extProgram.name,
                FontFamily = (FontFamily)Application.Current.Resources["settingFontFamilyContent"],
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };

            Image image = new Image()
            {
                Source = extProgram.icon,
                HorizontalAlignment = HorizontalAlignment.Left,
                Width = 50,
                Height = 50,
            };

            background.MouseDown += delegate (object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                OnProgramSelected();
            };

            ButtonEffects.Darken(background);
            ButtonEffects.Stroke(background, Brushes.LightBlue);

            grid.Children.Add(background);
            grid.Children.Add(image);
            grid.Children.Add(content);
        }

        protected virtual void OnProgramSelected()
        {
            if (ProgramSelected != null)
                ProgramSelected(this);
        }
    }
}
