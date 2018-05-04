using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Fill
    {
        static int[] array = new int[10];
        public Fill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        List<int> collection = new List<int> (array);
         
        public static IEnumerable<int> Filter()
        {
            for (int i; i<array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}