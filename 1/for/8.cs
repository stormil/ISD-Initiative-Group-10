using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            bool flag = false;
            do
            {
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                if (password == "root")
                {
                    Console.WriteLine("Пароль верный");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Неверный пароль ");
                }

            }
            while (!flag);
            Console.ReadKey();
        }
        
    }
}
