using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of km: ");
            int Kilometers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Time of waiting: ");
            int TimeOfWaiting = Convert.ToInt32(Console.ReadLine());
            int price;
            if(Kilometers <= 5)
            {
                price = 20 + TimeOfWaiting;
            }
            else
            {
                price = 20 + (Kilometers - 5) * 3 + TimeOfWaiting;
            }
            Console.WriteLine("Your price is: " + price);
            Console.ReadKey();
        }
    }
}
