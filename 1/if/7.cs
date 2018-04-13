using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<1000; i++)
            {
                Console.WriteLine(i);
                if (IsPrime(i))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
            Console.ReadKey();
        }

        public static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
