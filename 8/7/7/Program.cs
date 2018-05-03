using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1, "demonstration");
            list[0] = (int)list[0] + 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            list.Clear();

            list.Add("stranger", "dog", "apple", 34, 34.34);
            list.Remove("stranger");
            list.RemoveAt(0);
            if (list.Contains("apple"))
            {
                Console.WriteLine("List contains \"apple\"" + " at index # " + list.IndexOf("apple"));
            }

            


            Console.ReadKey();
        }
    }
}
