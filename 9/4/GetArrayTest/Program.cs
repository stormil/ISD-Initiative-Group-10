﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                1,2,3,4,5,6,7,8,9,11
            };

            int[] arr = list.GetArray();

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
