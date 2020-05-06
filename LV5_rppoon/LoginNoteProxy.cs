using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5_rppoon
{
    class LoginNoteProxy : IDataset
    {
        private Dataset dataset;
        public ReadOnlyCollection<List<string>> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
