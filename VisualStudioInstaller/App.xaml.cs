using System.Threading;
using System.Windows;
using XamlCSS.WPF;

namespace VisualStudioInstaller
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            Css.Initialize();

            InitializeComponent();
        }
    }
}
