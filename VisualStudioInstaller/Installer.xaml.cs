using System.Diagnostics;
using System.Windows;
using XamlCSS.WPF;

namespace VisualStudioInstaller
{
    /// <summary>
    /// Interaction logic for Installer.xaml
    /// </summary>
    public partial class Installer : Window
    {
        public Installer()
        {
            DataContext = new InstallerViewModel();

            InitializeComponent();
        }

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ToggleClass("light dark");
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);

            e.Handled = true;
        }

        private void Button_EditCss(object sender, RoutedEventArgs e)
        {
            this.ToggleClass("edit-mode");
        }
    }
}
