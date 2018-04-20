using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer myPrinter = new Printer();

            myPrinter.Print("This is Printer class");

            if(myPrinter is OtherPrinter)
            {
                OtherPrinter MyOtherPrinter = (OtherPrinter)myPrinter;
                MyOtherPrinter.Print("This is other printer class");
            }

            OtherPrinter mySecondOtherPrinter = new OtherPrinter();

            mySecondOtherPrinter.Print("This is mySecondOther printer");

            Printer mySecondPrinter = (Printer)mySecondOtherPrinter;

            mySecondPrinter.Print("mySecondOtherPrinter after upcast");

            OtherPrinter upCast = mySecondPrinter as OtherPrinter;

            if(upCast != null)
            {
                upCast.Print("My secondOtherPrinter after upcast");
            }


            Console.ReadKey();
        }
    }
}
