using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print your Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = (number == 0) ? 1 : 0;
            while (number != 0)
            {
                count++;
                number /= 10;
            }
            Console.WriteLine("Quantity of Numerals: " + count);
            Console.ReadKey();
        }
    }
}
