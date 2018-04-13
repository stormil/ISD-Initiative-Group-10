using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу ставку");
            int prise = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int n = rnd.Next(1, 13);
            if (n>=1 && n>=5)
            {
                prise = 0;
                Console.WriteLine("Вы проиграли :::'((( Ваш выигрыш составляет: " + prise);
            }
            else if(n>=6 && n<=8){
                Console.WriteLine("Вы ничего не потеряли но ничего и не выиграли. Ваш выигрыш составляет: " + prise); 
            }
            else
            {
                prise = prise * 10;
                Console.WriteLine("Ваш выигрыш приумножен на 10 и составляет: " + prise);
            }
            Console.ReadKey();
        }
    }
}
