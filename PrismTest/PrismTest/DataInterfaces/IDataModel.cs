using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTest.DataInterfaces
{
    /// <summary>
    /// Interface for the data management
    /// </summary>
    public interface IDataModel
    {
        string StatusText { get; set; }
        Uri FilePath { get; set; }
    }
}
