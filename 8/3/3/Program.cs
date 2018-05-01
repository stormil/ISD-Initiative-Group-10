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
            var dictionary = new MyDictionary<int, string>();
            dictionary[23] = "work horse";
            dictionary.Add(1, "day 2");

            Console.WriteLine(dictionary[23]);
            Console.WriteLine(dictionary[1]);
            Console.WriteLine("Amount of elements: " + dictionary.Amount);
            Console.ReadKey();
        }
    }
}
