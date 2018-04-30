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
using XamlCSS;
using XamlCSS.WPF;

namespace Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleLight_Click(object sender, RoutedEventArgs e)
        {
            this.ToggleClass("light");
            

            if (ToggleLight.Tag == null)
            {
                ToggleLight.Tag = "False";
            }

            ToggleLight.Tag = ((string)ToggleLight.Tag == "True") ? "False" : "True";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var stylesheet = Resources["windowStyle"] as StyleSheet;
            stylesheet.SingleBaseStyleSheet = stylesheet.SingleBaseStyleSheet == App.Current.Resources["inlineStyle"] ? (StyleSheet)App.Current.Resources["inlineStyleAdvanced"] : (StyleSheet)App.Current.Resources["inlineStyle"];
        }
    }
}
