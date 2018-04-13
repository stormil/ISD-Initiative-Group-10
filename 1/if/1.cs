using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber < secondNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(firstNumber);
            }

            Console.ReadKey();
        }
    }
}
