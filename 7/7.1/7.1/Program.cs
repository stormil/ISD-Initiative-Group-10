using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    public delegate double AverageCount(int x, int y, int z);
    class Program
    {
        public static void Counter(AverageCount counter)
        {
            int x, y, z;
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(counter(x,y,z)/3);
        }
        static void Main(string[] args)
        {
            AverageCount averageCounter = delegate (int a, int s, int d)
            {
                return (double)(a + s + d) / 3;
            };
            Counter(averageCounter);
            Console.ReadKey();
        }
     }
}