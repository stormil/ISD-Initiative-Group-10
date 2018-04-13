using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of money: ");
            decimal money = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter currency type(UAH, EUR, USD): ");
            string currencyType = Convert.ToString(Console.ReadLine());

            if(currencyType == "UAH" || currencyType == "uah")
            {
                Console.WriteLine($"EUR: {money * (decimal)0.03}");
                Console.WriteLine($"USD: {money * (decimal)0.04}");
            }
            else
            {
                if(currencyType == "EUR" || currencyType == "eur")
                {
                    Console.WriteLine($"UAH: {money * (decimal)32.02}");
                    Console.WriteLine($"USD: {money * (decimal)1.23}");
                }
                else
                {
                    if (currencyType == "USD" || currencyType == "usd")
                    {
                        Console.WriteLine($"UAH: {money * (decimal)25.99}");
                        Console.WriteLine($"EUR: {money * (decimal)0.81}");
                    }
                    else
                    {
                        Console.WriteLine("Uknown currency type");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
