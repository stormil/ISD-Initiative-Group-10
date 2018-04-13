using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N for  multiplication table: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} * {numberN} = {i * numberN}");
            }

            Console.ReadKey();
        }
    }
}
