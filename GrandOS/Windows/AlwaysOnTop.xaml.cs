using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void MainBorder_MouseEnter(object sender, MouseEventArgs e)
        {
            Trace.WriteLine(GetActiveWindowTitle());
            Trace.WriteLine(GetActiveWindowFileName());
        }

        private void MainBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();


        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern int GetWindowModuleFileName(IntPtr hWnd, StringBuilder pszFileName, int cchFileNameMax);

        private string GetActiveWindowFileName()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowModuleFileName(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        
    }
}
