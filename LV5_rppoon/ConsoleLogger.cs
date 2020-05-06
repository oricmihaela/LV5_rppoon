using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;
        public static ConsoleLogger GetInstance()
        {
            if(instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }
        public void Log(string messageForOutput)
        {
            Console.WriteLine(messageForOutput);
        }
    }
}
