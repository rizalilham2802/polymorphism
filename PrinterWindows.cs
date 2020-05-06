using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class PrinterWindows
    {
        public string Name { get; set;}

        public virtual void Show()
        {
            Console.WriteLine(" printer display dimension");
        }
        public virtual void Print()
        {
            Console.WriteLine("printer printing . . .");
        }
    }
}
