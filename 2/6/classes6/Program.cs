using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes6
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("press \"1\" - uah to usd");
            Console.WriteLine("press \"2\" - uah to eur");
            Console.WriteLine("press \"3\" - uah to rub");
            Console.WriteLine("press \"4\" - usd to uah");
            Console.WriteLine("press \"5\" - eur to uah");
            Console.WriteLine("press \"6\" - rub to uah");
        }
        static void Main(string[] args)
        {
            Console.Write("Input currency of USD, EUR and RUB: ");
            double usd1 = Convert.ToDouble(Console.ReadLine());
            double eur1 = Convert.ToDouble(Console.ReadLine());
            double rub1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input amount of your money: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Converter converter1 = new Converter(usd1, eur1, rub1);
            Menu();
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(converter1.ConvertCurrency(amount, action));
            Console.ReadKey();
        }
    }
}
