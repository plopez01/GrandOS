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
    /// Lógica de interacción para AddProgramPopup.xaml
    /// </summary>
    public partial class AddProgramPopup : Window
    {
        public AddProgramPopup()
        {
            InitializeComponent();

            Height = SystemParameters.PrimaryScreenHeight * (1000.0 / 1080.0);
            Width = SystemParameters.PrimaryScreenWidth * (600.0 / 1920.0);
        }

        private void window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }

    }
}
