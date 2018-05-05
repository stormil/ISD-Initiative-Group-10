using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        public int Amount { get => Keys.Count; }
        public List<TKey> Keys { get; } = new List<TKey>();

        public List<TValue> Values { get; } = new List<TValue>();

        public TValue this[TKey index]
        {
            get
            {
                if (Keys.Contains(index))
                {
                    return Values[Keys.IndexOf(index)];
                }
                throw new ArgumentException();
            }
            set => Add(index, value);
        }
        public void Add(TKey key, TValue value)
        {
            if (Keys.Contains(key))
            {
                Values[Keys.IndexOf(key)] = value;
            }
            else
            {
                Keys.Add(key);
                Values.Add(value);
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < Keys.Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(Keys[i], Values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool ContainsKey(TKey key)
        {
            return Keys.Contains(key);
        }
        public bool ContainsValue(TValue value)
        {
            return Values.Contains(value);
        }
    }
}
