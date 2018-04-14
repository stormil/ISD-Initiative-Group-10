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
            int kilometers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Time of waiting: ");
            int timeOfWaiting = Convert.ToInt32(Console.ReadLine());
            int price;
            if (kilometers <= 5)
            {
                price = 20 + timeOfWaiting;
            }
            else
            {
                price = 20 + (kilometers - 5) * 3 + timeOfWaiting;
            }
            Console.WriteLine("Your price is: " + price);
            Console.ReadKey();
        }
    }
}
