using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrismTest.Entities
{
    /// <summary>
    /// This class manages the state of the data model. This is not serialized directly,
    /// but is, rather, just a manager for such things.
    /// </summary>
    internal sealed class DataModel : DataInterfaces.IDataModel
    {
        private Uri _filePath;
        private string _statusText;

        public string StatusText { get => _statusText; set { _statusText = value; RaisePropertyChanged(); } }
        public Uri FilePath { get => _filePath; set { _filePath = value; RaisePropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
