using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using PrismTest.ServiceInterfaces;

namespace PrismTest.Services
{
    class DiskFilePathService : IUriService
    {
        public DiskFilePathService([Dependency] IFileDialogService dialogService)
        {
            FileDialogService = dialogService;
        }

        public IFileDialogService FileDialogService { get; private set; }

        public string GetDataModelUri() 
            => FileDialogService.GetOpenFilePath(("Json files", "*.json"), ("All files", "*.*"));
    }
}
