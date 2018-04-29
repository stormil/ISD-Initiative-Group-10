using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static Random random = new Random();

        static Func<Func<int>[], double> ArrayCalculator;

        static void Main(string[] args)
        {
            Console.WriteLine("Input size of array:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                var delegateArray = new Func<int>[n];
                for (int i = 0; i < delegateArray.Length; i++)
                {
                    delegateArray[i] = () => random.Next(int.MinValue, int.MaxValue);
                }

                ArrayCalculator = (Func<int>[] array) =>
                {
                    long sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] != null)
                        {
                            sum += array[i]();
                        }
                    }
                    return (double)sum / array.Length;
                };

                Console.WriteLine("Average is: " + ArrayCalculator(delegateArray));
            }
            else
            {
                Console.WriteLine("Your input is wrong");
            }
            Console.ReadKey();
        }
    }
}
