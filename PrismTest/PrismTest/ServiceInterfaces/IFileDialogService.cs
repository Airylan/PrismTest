using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTest.ServiceInterfaces
{
    interface IFileDialogService
    {
        string GetOpenFilePath(params (string name, string filter)[] filters);
        string GetSaveFilePath(params (string name, string filter)[] filters);
        string GetFolderPath();
    }
}
