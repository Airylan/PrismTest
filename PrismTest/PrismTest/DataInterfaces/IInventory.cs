using System.Collections.Generic;
using System.ComponentModel;

namespace PrismTest.DataInterfaces
{
    public interface IInventory : INotifyPropertyChanged
    {
        IEnumerable<IProduct> Products { get; set; }
        IEnumerable<ISalesOrder> Sales { get; set; }
    }
}