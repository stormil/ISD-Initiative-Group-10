using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Word: ");
            string soundByCat = "мяу";
            string soundByDog = "гав";
            string enteredWord = Console.ReadLine();
            if (enteredWord == soundByCat)
            {
                Console.WriteLine("Покорми кота");
            }
            else if (enteredWord == soundByDog)
            {
                Console.WriteLine("Погуляй с собакой");
            }
            else { }
            Console.ReadKey();
        }
    }
}
