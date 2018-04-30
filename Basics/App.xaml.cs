using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using XamlCSS.WPF;

namespace Basics
{
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
