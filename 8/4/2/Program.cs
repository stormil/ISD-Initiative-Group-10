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
            my.Add(10);
            my.Add(11);
            my.Add(12);
            my.Add(13);
            my.Add(14);
            my.Add(15);
            my.Add(16);
            my.Add(17);
            my.Add(18);
            my.Add(19);
            my.Add(20);
            my.Add(21);

            /*           int[] arr = my.GetArray();

                       foreach(int i in arr)
                       {
                           Console.Write(i + " ");
                       }*/

            Console.WriteLine("SomeText");
            Console.WriteLine(my[1]);

            Console.ReadKey();
        }
    }
}
