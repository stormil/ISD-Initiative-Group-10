using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadKey();
        }
    }
}
