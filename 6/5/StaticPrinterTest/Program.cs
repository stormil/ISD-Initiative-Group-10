using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPrinterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string line = Console.ReadLine();

            Console.Write("Select color (Black - 1, Gray - 2, " +
                "Green - 3, Red - 4, White - 5, Yellow - 6): ");
            Color color;
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    color = Color.Black;
                    break;
                case 2:
                    color = Color.Gray;
                    break;
                case 3:
                    color = Color.Green;
                    break;
                case 4:
                    color = Color.Red;
                    break;
                case 5:
                    color = Color.White;
                    break;
                case 6:
                    color = Color.Yellow;
                    break;
                default:
                    color = Color.White;
                    break;
            }

            Printer.Print(line, (int)color);

            Console.ReadKey();
        }
    }
}
