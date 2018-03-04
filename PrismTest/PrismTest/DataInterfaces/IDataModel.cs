using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTest.DataInterfaces
{
    /// <summary>
    /// Interface for the data management
    /// </summary>
    public interface IDataModel : INotifyPropertyChanged
    {
        string StatusText { get; set; }
        Uri FilePath { get; set; }

        IInventory inventory { get; set; }
    }
}
