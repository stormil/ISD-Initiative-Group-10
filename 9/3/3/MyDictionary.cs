using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class KeyValuePair<TKey, TValue>
    {
        public KeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public TValue Value { get; set; }
        public TKey Key { get; set; }

        public override string ToString()
        {
            return "[" + Key + ", " + Value + "]";
        }
    }

    class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        List<TKey> keys = new List<TKey>();
        List<TValue> values = new List<TValue>();
        public int Amount { get => keys.Count; }
        public List<TKey> Keys
        {
            get
            {
                return keys;
            }
        }
        public List<TValue> Values
        {
            get
            {
                return values;
            }
        }
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

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool ContainsKey(TKey key)
        {
            return keys.Contains(key);
        }
        public bool ContainsValue(TValue value)
        {
            return values.Contains(value);
        }
    }
}
