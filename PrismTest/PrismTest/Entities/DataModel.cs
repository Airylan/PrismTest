using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTest.Entities
{
    /// <summary>
    /// This class manages the state of the data model. This is not serialized directly,
    /// but is, rather, just a manager for such things.
    /// </summary>
    internal class DataModel : DataInterfaces.IDataModel
    {
        public string StatusText { get; set; }
        public Uri FilePath { get; set; }
    }
}
