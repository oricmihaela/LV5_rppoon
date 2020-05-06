using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    class MagentaTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
