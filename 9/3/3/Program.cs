using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string> // my dictionary
            {
                { 1, "house" },
                { 2, "dog" },
                { 3, "Leo" },
                { 342, "day" }
            };

            Dictionary<int, string> standartDictionary = new Dictionary<int, string> // standart dictionary
            {
                { 5, "home" },
                { 3, "cat" },
                { 4, "Kate" },
                { 334, "night" }
            };
            Console.WriteLine("Foreach in standart dictionary collection:");
            foreach (var entry in standartDictionary)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine("\nForeach in my dictionary collection:");
            foreach (var entry in myDictionary)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine("\nForeach just for values in my dictionary:");
            foreach (var entry in myDictionary.Values)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}
