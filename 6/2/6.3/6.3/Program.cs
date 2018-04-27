using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayOfTrains trains = new ArrayOfTrains();
            trains.Initialisation();
            Console.WriteLine("Input Number of searching train: ");
            int number = Convert.ToInt32(Console.ReadLine());
            trains.InfoTrain(number);
            Console.ReadKey();
        }
    }
}
