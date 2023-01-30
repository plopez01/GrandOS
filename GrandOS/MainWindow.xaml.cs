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
using GrandOS.UI.Elements;
using GrandOS.UI;
using GrandOS.Programs;
using System.Globalization;
using GrandOS.Windows;
using GrandOS.Programs.Base;

namespace GrandOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AlwaysOnTop alwaysOnTop;

        public MainWindow()
        {
            //Application.Current.Resources["settingFontFamilyContent"] = new FontFamily("Segoe UI");
            // new Program("Correu", Brushes.BlueViolet), new Program("Fotoeeds", Brushes.Orange)
            InitializeComponent();

            new Clock(clockLabel, "HH:mm", dateLabel, "D");


            List<Program> programs = new List<Program>(){ new LinkerProgram("https://mail.google.com/"), new ExecutableProgam("calc.exe") };

            new ProgramGrid(appGird, 5, 2, 5, 5, programs);

            alwaysOnTop = new AlwaysOnTop();
            alwaysOnTop.SetUpPos();
            alwaysOnTop.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            alwaysOnTop.SetUpPos();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            alwaysOnTop.SetDownPos();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}
