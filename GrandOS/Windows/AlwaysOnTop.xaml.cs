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
using System.Windows.Shapes;

namespace GrandOS.Windows
{
    /// <summary>
    /// Interaction logic for AlwaysOnTop.xaml
    /// </summary>
    public partial class AlwaysOnTop : Window
    {
        public AlwaysOnTop()
        {
            InitializeComponent();

            // Adjust for resolution changes
            Height = SystemParameters.PrimaryScreenHeight * 0.1;
            Width = Height;
        }

        public void SetUpPos()
        {
            window.Left = SystemParameters.PrimaryScreenWidth * 0.9;
            window.Top = SystemParameters.PrimaryScreenHeight * 0.15;
        }

        public void SetDownPos()
        {
            window.Left = SystemParameters.PrimaryScreenWidth * 0.9;
            window.Top = SystemParameters.PrimaryScreenHeight * 0.85;
        }

        private void window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }
    }
}
