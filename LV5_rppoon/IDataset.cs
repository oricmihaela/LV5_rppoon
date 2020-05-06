using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5_rppoon
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
