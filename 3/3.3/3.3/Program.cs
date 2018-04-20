using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Mercedes = new Car(x: 18, y: 35, price: 30000, speed: 240, year: 1915);
            Vehicle Boeing = new Plane(x: 68, y: 48, price: 150000, speed: 240, year: 1950, height:15, capacity:2500 );
            Vehicle Titanic = new Ship(x: 27, y: 53, price: 3000000, speed: 240, year: 1936, capacity:100, port:124);

            Console.WriteLine(Mercedes);
            Console.WriteLine(Boeing);
            Console.WriteLine(Titanic);
            Console.ReadKey();
        }
    }
}
