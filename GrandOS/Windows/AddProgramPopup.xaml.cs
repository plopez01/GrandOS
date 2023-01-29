using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            // https://learn.microsoft.com/en-us/windows/win32/shell/knownfolderid
            // https://stackoverflow.com/questions/908850/get-installed-applications-in-a-system
            /*ShellObject appsFolder = (ShellObject) KnownFolderHelper.FromKnownFolderId(new Guid("{1e87508d-89c2-42f0-8a7e-645a0f50ca58}"));

            // This is really slow and causes a big memory spike, caching this list may be a good idea
            foreach (var app in (IKnownFolder) appsFolder)
            {
                // The friendly app name
                string name = app.Name;
                // The ParsingName property is the AppUserModelID
                string appUserModelID = app.ParsingName; // or app.Properties.System.AppUserModel.ID
                                                         // You can even get the Jumbo icon in one shot
                ImageSource icon = app.Thumbnail.ExtraLargeBitmapSource;
                //Trace.WriteLine(name);
            }*/

            Rectangle rect = new Rectangle()
            {
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 50,
                Height = 50,
                Fill = Brushes.Red,
            };

            titleGrid.Children.Add(rect);

        }

        private void window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }

    }
}
