using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> park = new CarCollection<Car>();

            park.Add(new Car
            {
                Mark = "Volvo",
                ProductYear = 2017
            });
            park.Add(new Car
            {
                Mark = "Kia",
                ProductYear = 2016
            });
            park.Add(new Car
            {
                Mark = "BMW",
                ProductYear = 2018
            });
            park.Add(new Car
            {
                Mark = "Toyota",
                ProductYear = 2014
            });

            for(int i = 0; i < park.Count; i++)
            {
                Console.WriteLine(park[i]);
            }

            park.ClearPark();

            Console.WriteLine($"The size after cleaning: {park.Count}");

            Console.ReadKey();
        }
    }
}
