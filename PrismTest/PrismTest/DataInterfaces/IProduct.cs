using System.ComponentModel;

namespace PrismTest.DataInterfaces
{
    public interface IProduct : INotifyPropertyChanged
    {
        string Name { get; set; }
        string Description { get; set; }
        string Id { get; set; }
        int Quantity { get; set; }
    }
}