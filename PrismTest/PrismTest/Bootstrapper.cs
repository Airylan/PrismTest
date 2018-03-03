using System.Windows;
using Prism.Unity;
using Microsoft.Practices.Unity;
using PrismTest.Views;

namespace PrismTest
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell() => Container.Resolve<MainWindowView>();

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<MainWindowView>();
            Container.RegisterType<DataInterfaces.IDataModel, Entities.DataModel>();
        }
    }
}