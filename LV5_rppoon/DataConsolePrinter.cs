using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    class DataConsolePrinter
    {
        public void Print(IDataset data)
        {
            if (data.GetData() == null)
            {
                Console.WriteLine("No right of access.");
                return;
            }
            foreach (List<string> current in data.GetData())
            {
                foreach (string innerCurrent in current)
                {
                    Console.Write(innerCurrent + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
