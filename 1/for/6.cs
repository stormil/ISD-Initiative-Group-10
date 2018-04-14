using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[5];
            Console.Write("Random Array: ");
            for (int i = 0; i < 5; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.Write(array[i] + "  ");
            }
            int ans = 0;
            for (int i = 0; i < 5; i++)
            {
                ans += array[i];
            }
            Console.WriteLine("\n" + "Average: " + ans / 5);
            Console.ReadKey();
        }
    }
}
