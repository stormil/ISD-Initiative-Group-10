using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    static class Util
    {
        public static T[] GetArray<T>(this MyList<T> l)
        {
            T[] array = new T[l.Count];
            for (int i = 1; i <= l.Count; i++)
            {
                array[i] = l[i];
            }
            return array;
        }
    }
}
