using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Mvvm;
using PrismTest.DataInterfaces;
using PrismTest.ServiceInterfaces;

namespace PrismTest.ViewModels
{
    class ImportViewModel : BindableBase
    {
        public ImportViewModel([Dependency] IDataModel dataModel, [Dependency] IUriService uriService, [Dependency] IDataImportService importService)
        {
            DataModel = dataModel;
            UriService = uriService;
            ImportService = importService;
        }

        public IDataModel DataModel { get; private set; }
        public IUriService UriService { get; private set; }
        public IDataImportService ImportService { get; }

        public string FilePath
        {
            get { return DataModel.FilePath?.LocalPath; }
            set
            {
                // TODO: Error Handling here
                DataModel.FilePath = new Uri(value);
                DataModel.StatusText = value;
                RaisePropertyChanged();
            }
        }

        public string FilePathLabelText => "File Path: ";
        public string ImportLabel => "Import";

        // Usually I don't like using DelegateCommands, but for these I'll go with it.
        public ICommand FindFilePathCommand => new DelegateCommand(FindFilePath);

        private void FindFilePath()
        {
            FilePath = UriService.GetDataModelUri();
        }

        private void ImportFileCommand()
        {

        }
    }
}
