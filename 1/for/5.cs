﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] array = new int[size];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int summ = 0;

            for (int i = 0; i < size; i++)
            {
                summ += array[i];
            }

            double aver = summ / (double)size;

            Console.WriteLine($"Average is {aver}");

            Console.ReadKey();
        }
    }
}
