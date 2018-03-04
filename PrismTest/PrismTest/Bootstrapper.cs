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

            // Register main types
            Container.RegisterType<MainWindowView>();

            // Register data model backing
            // Note the ContainerControlledLifetimeManager parameter. This returns
            // the same instance of the data model context while the lifetime manager
            // exists (it uses IDisposable to manage this)
            Container.RegisterType<DataInterfaces.IDataModel, Entities.DataModel>(new ContainerControlledLifetimeManager());

            // Register "Strategy" types for implementing behaviour requests
            // Note: this could be done through attribute annotations on classes,
            //       but this works just fine.
            Container.RegisterType<ServiceInterfaces.IUriService, Services.DiskFilePathService>();
            Container.RegisterType<ServiceInterfaces.IDataImportService, Services.JsonDataImportService>();
            Container.RegisterType<ServiceInterfaces.IFileDialogService, Services.ComonWindowsFileDialogService>();

            // Register types for navigation
            Container.RegisterTypeForNavigation<ImportView>();
            Container.RegisterTypeForNavigation<EditView>();
        }
    }
}