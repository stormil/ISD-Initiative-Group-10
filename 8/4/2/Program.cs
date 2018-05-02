using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> my = new MyList<int>();

            for(int i = 0; i < 10; i++)
            {
                my.Add(i + 1);
            }

            int[] arr = my.GetArray();

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
