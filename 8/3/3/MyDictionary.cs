using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class MyDictionary<TKey, TValue> : Dictionary<TKey, TValue>
        where TKey : IComparable
    {
        List<TKey> keys = new List<TKey>();
        List<TValue> values = new List<TValue>();
        public int Amount { get => keys.Count; }

        public TValue this[TKey index]
        {
            get
            {
                if (keys.Contains(index))
                {
                    return values[keys.IndexOf(index)];
                }
                throw new ArgumentException();
            }
            set => Add(index, value);
        }
        public void Add(TKey key, TValue value)
        {
            if (keys.Contains(key))
            {
                values[keys.IndexOf(key)] = value;
            }
            else
            {
                keys.Add(key);
                values.Add(value);
            }
        }
    }
}
