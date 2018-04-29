using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        delegate double Average(int first, int second, int third);
        static void Main(string[] args)
        {
            Average average = delegate (int a, int b, int c)
            {
                return (double) (a + b + c) / 3;
            };
            Console.Write("Input 1st Number ");
            int fir = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd Number ");
            int sec = int.Parse(Console.ReadLine());
            Console.Write("Input 3rd Number ");
            int thir = int.Parse(Console.ReadLine());
            Console.Write("Average of inputed numbers is: ");
            Console.Write(average(fir, sec, thir));
            Console.ReadKey();
        }
    }
}
