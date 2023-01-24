using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GrandOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Application.Current.Resources["settingFontFamilyContent"] = new FontFamily("Segoe UI");

            InitializeComponent();

            _ = new Clock(clockLabel, "HH:mm", dateLabel, "D");

            var rect = new Rectangle()
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 50,
                Height = 50,
                Fill = Brushes.AliceBlue
            };
            appGird.Children.Add(rect);
            var rect2 = new Rectangle()
            {
                Margin = new Thickness(60, 0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 50,
                Height = 50,
                Fill = Brushes.AliceBlue
            };

            
            appGird.Children.Add(rect2);
        }
    }
}
