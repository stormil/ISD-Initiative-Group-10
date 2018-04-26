using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size of array:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int[] a = new int[n];
                Console.WriteLine("Input array:");
                for (int i = 0; i < n; i++)
                {
                    if (!int.TryParse(Console.ReadLine(), out a[i]))
                    {
                        Console.WriteLine("Wrong input");
                        i--;
                    }
                }
                
                a.SortQuick(0, n - 1);

                Console.WriteLine("Input 1 if you want sorting from the beginning to the end");
                Console.WriteLine("Else input no 1");
                int flag = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sorted array:");
                if (flag == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(a[i] + " ");
                    }
                }
                else
                {
                    for(int i = n - 1; i >= 0; i--)
                    {
                        Console.Write(a[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            Console.ReadKey();
        }
    }
}
