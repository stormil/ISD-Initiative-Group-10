using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address();

            address1.Index = 49010;
            address1.Country = "Ukraine";
            address1.City = "Dnepr";
            address1.Street = "Gagarina";
            address1.House = 28;
            address1.Apartment = 320;

            Console.WriteLine($"{address1.Index} {address1.Country} {address1.City} {address1.Street} {address1.House} {address1.Apartment}");

            Console.ReadKey();
        }
    }
}
