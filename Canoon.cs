using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Canoon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canoon display dimension : 9.5*12 ");
        }
        public override void Print()
        {
            Console.WriteLine("Canoon Printer Printing....");
        }
    }
}
