using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer prin = new Printer();

            prin.Print("askjfhl");

            OtherPrinter opr = (OtherPrinter)prin;

            opr.Print("lasjhgfdjksg");

            Console.ReadKey();

        }
    }
}
