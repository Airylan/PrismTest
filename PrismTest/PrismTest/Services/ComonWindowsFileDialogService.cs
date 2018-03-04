using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;
using PrismTest.ServiceInterfaces;

namespace PrismTest.Services
{
    class ComonWindowsFileDialogService : IFileDialogService
    {
        public string GetFolderPath()
            => DoDialog(new CommonOpenFileDialog { IsFolderPicker = true });

        public string GetOpenFilePath(params (string name, string filter)[] filters)
            => DoDialog(new CommonOpenFileDialog(), filters);

        public string GetSaveFilePath(params (string name, string filter)[] filters)
            => DoDialog(new CommonSaveFileDialog(), filters);

        private string DoDialog(CommonFileDialog dialog, params (string name, string filter)[] filters)
        {
            foreach (var filter in filters.Select(x => new CommonFileDialogFilter(x.name, x.filter)))
            {
                dialog.Filters.Add(filter);
            }
            var result = dialog.ShowDialog();
            return result == CommonFileDialogResult.Ok ? dialog.FileName : null;
        }
    }
}
