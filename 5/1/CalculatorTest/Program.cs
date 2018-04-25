using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorTest.Calculator;
using static System.Console;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"2 + 2 = {Plus(2,2)}");
            WriteLine($"2 - 2 = {Minus(2, 2)}");
            WriteLine($"2 * 2 = {Multiplication(2, 2)}");
            WriteLine($"2 / 2 = {Division(2, 2)}");
            WriteLine($"2 / 0 = {Division(2, 0)}");

            ReadKey();
        }
    }
}
