using System.Collections.ObjectModel;
using System.ComponentModel;
using VisualStudioInstallerCore;

namespace VisualStudioInstallerCore
{
    public class InstallerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Item> Installed => new ObservableCollection<Item>
        {
            new Item
            {
                Title = "Visual Studio Community 2017",
                Version ="15.8.4",
                Info = InstallerResources.Info_Community,
                Link = "https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#15.8.4"
            },
            new Item
            {
                Title = "Visual Studio Professional 2017",
                Version ="15.8.4",
                Info = InstallerResources.Info_Professional,
                Link = "https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#15.8.4"
            }
        };

        public ObservableCollection<Item> Release => new ObservableCollection<Item>
        {
            new Item
            {
                Title = "Visual Studio Enterprise 2017",
                Version ="15.8.4",
                Info = InstallerResources.Info_Enterprise,
                Link = "https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#15.8.4"
            }
        };

        public ObservableCollection<Item> Preview => new ObservableCollection<Item>
        {
            new Item
            {
                Title = "Visual Studio Community 2017",
                Version ="15.9.0 Preview 2.0",
                Info = InstallerResources.Info_Community,
                Link = "https://www.visualstudio.com/en-us/news/releasenotes/vs2017-preview-relnotes#15.9_P2"
            },
            new Item
            {
                Title = "Visual Studio Professional 2017",
                Version ="15.9.0 Preview 2.0",
                Info = InstallerResources.Info_Professional,
                Link = "https://www.visualstudio.com/en-us/news/releasenotes/vs2017-preview-relnotes#15.9_P2"
            },
            new Item
            {
                Title = "Visual Studio Enterprise 2017",
                Version ="15.9.0 Preview 2.0",
                Info = InstallerResources.Info_Enterprise,
                Link = "https://www.visualstudio.com/en-us/news/releasenotes/vs2017-preview-relnotes#15.9_P2"
            }
        };

        public event PropertyChangedEventHandler PropertyChanged;

        public class Item
        {
            public string Title { get; set; }
            public string Version { get; set; }
            public string Info { get; set; }
            public string Link { get; set; }
        }
    }
}
