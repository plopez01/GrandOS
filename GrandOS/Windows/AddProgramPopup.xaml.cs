using GrandOS.Programs;
using GrandOS.UI;
using GrandOS.UI.Elements.Buttons;
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
        public AddProgramPopup(ProgramGrid programGrid, int cellX, int cellY)
        {
            InitializeComponent();

            Height = SystemParameters.PrimaryScreenHeight * (1000.0 / 1080.0);
            Width = SystemParameters.PrimaryScreenWidth * (600.0 / 1920.0);

            titleGrid.Width = Width;
            titleGrid.Height = Height;

            // https://learn.microsoft.com/en-us/windows/win32/shell/knownfolderid
            // https://stackoverflow.com/questions/908850/get-installed-applications-in-a-system
            ShellObject appsFolder = (ShellObject) KnownFolderHelper.FromKnownFolderId(new Guid("{1e87508d-89c2-42f0-8a7e-645a0f50ca58}"));

            // TODO: This is really slow and causes a big memory spike, caching this list may be a good idea, or maybe loading dinamically
            foreach (var app in (IKnownFolder) appsFolder)
            {
                // This call is computationally expensive, as we are loading lots of images into memory
                ImageSource icon = app.Thumbnail.MediumBitmapSource;

                ExternalProgram extProgram = new ExternalProgram(app.Name, app.ParsingName, Brushes.DarkSalmon, icon);

                AddProgramButton button = new AddProgramButton(programStack, extProgram, new Thickness(0));

                button.AddToStackPanel(programStack);

                button.ProgramSelected += delegate (object program)
                {
                    programGrid.AddProgam(extProgram, cellX, cellY);
                    Close();
                };
            }

            new CloseButton(titleGrid, this);
        }

        private void window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }

    }
}
