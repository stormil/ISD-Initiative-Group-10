using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPrinterTest
{
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            ConsoleColor colorText;
            switch(color)
            {
                case 0:
                    colorText = ConsoleColor.Black;
                    break;
                case 7:
                    colorText = ConsoleColor.Gray;
                    break;
                case 10:
                    colorText = ConsoleColor.Green;
                    break;
                case 12:
                    colorText = ConsoleColor.Red;
                    break;
                case 15:
                    colorText = ConsoleColor.White;
                    break;
                case 14:
                    colorText = ConsoleColor.Yellow;
                    break;
                default:
                    colorText = ConsoleColor.White;
                    break;
            }

            Console.ForegroundColor = colorText;
            Console.WriteLine(stroka);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
