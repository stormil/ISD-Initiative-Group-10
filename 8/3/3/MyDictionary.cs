using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class MyDictionary<TKey, TValue>
    {
        Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
        public int Amount { get => dictionary.Count; }

        public TValue this[TKey key]
        {
            get
            {
                return dictionary[key];
            }
            set
            {
                dictionary[key] = value;
            }
        }
        public void Add(TKey key, TValue value)
        {
            dictionary[key] = value;
        }
    }
}
