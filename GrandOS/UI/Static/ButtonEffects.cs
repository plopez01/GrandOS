using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI.Static
{
    internal static class ButtonEffects
    {
        public static void Darken(Rectangle background, byte amount = 50)
        {
            background.MouseEnter += delegate (object sender, System.Windows.Input.MouseEventArgs e)
            {
                Color backColor = ((SolidColorBrush)background.Fill).Color;
                backColor.A -= amount;
                background.Fill = new SolidColorBrush(backColor);
            };

            background.MouseLeave += delegate (object sender, System.Windows.Input.MouseEventArgs e)
            {
                Color backColor = ((SolidColorBrush)background.Fill).Color;
                backColor.A += amount;
                background.Fill = new SolidColorBrush(backColor);
            };
        }

        public static void Stroke(Rectangle background, Brush color, byte stroke = 5)
        {
            background.MouseEnter += delegate (object sender, System.Windows.Input.MouseEventArgs e)
            {
                background.Stroke = color;
                background.StrokeThickness = stroke;
            };

            background.MouseLeave += delegate (object sender, System.Windows.Input.MouseEventArgs e)
            {
                background.StrokeThickness = 0;
            };
        }
    }
}
