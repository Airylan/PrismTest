using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Regions;
using PrismTest.DataInterfaces;

namespace PrismTest.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel([Dependency] IDataModel dataModel, [Dependency] IRegionManager regionManager)
        {
            DataModel = dataModel;
            RegionManager = regionManager;
        }

        private IDataModel DataModel { get; set; }
        private IRegionManager RegionManager { get; set; }

        public string StatusText => DataModel.StatusText;

        private ListBoxItem _currentNavigation;
        public ListBoxItem CurrentNavigation
        {
            get { return _currentNavigation; }
            set { SetProperty(ref _currentNavigation, value); Navigate(_currentNavigation?.Tag?.ToString() ?? ""); }
        }

        private void Navigate(string tag)
        {
            RegionManager.RequestNavigate("ContentPanel", tag);
        }
    }
}
