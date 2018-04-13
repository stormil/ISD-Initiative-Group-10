using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 или 0");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<=1 && n>=0)
            {
                if (n==1) {
                    Console.WriteLine("Хорошо");
                }
                else
                {
                    Console.WriteLine("Плохо");
                }

            } 
            else
            {
                Console.WriteLine("Вы не правильно ввели число");
            }
            Console.ReadKey();
        }
    }
}
