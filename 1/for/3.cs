using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Guess
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int randomNumber = random.Next(1, 147);
            Console.WriteLine("Угадайте цифру от 1 до 146");
            int userNumber;
            do
            {
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber > randomNumber)
                {
                    Console.WriteLine("меньше");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine("больше");
                }
                else
                {
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                }
            }
            while (userNumber != randomNumber);
            Console.ReadKey();
        }
    }
}
