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
            string SoundByCat = "мяу";
            string SoundByDog = "гав";
            string EnteredWord = Console.ReadLine();
            if (EnteredWord == SoundByCat)
            {
                Console.WriteLine("Покорми кота");
            }
            else if (EnteredWord == SoundByDog)
            {
                Console.WriteLine("Погуляй с собакой");
            }
            else { }
            Console.ReadKey();
        }
    }
}
