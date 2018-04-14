using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
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
