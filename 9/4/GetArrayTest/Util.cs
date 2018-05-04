using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArrayTest
{
    static class Util
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            IEnumerator<T> l = list.GetEnumerator();
            l.Reset();

            int size = 0; 

            while(l.MoveNext())
            {
                size++;
            }
            l.Reset();

            T[] array = new T[size];

            l.MoveNext();

            for (int i = 0; i < size; i++)
            {
                array[i] = l.Current;
                l.MoveNext();
            }
    
            return array;
        }
    }
}
