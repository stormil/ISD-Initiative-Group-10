using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Printer
    {
        public void Print(string value)
        {
            if(typeof(Printer) == GetType())
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine(value);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
