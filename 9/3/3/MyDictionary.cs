using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Pair<TKey, TValue>
    {
        public Pair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public TValue Value { get; set; }
        public TKey Key { get; set; }

        public override string ToString()
        {
            return "[ " + Key + ", " + Value + " ]";
        }
    }

    class MyDictionary<TKey, TValue> : IEnumerable <Pair<TKey, TValue>>
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

        public IEnumerator<Pair<TKey, TValue>> GetEnumerator()
        {
            return new MyDictionaryEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class MyDictionaryEnumerator: IEnumerator<Pair<TKey, TValue>>
        {
            MyDictionary<TKey, TValue> dictionary;
            TKey currentKey;
            TValue currentValue;
            int index;

            public MyDictionaryEnumerator(MyDictionary<TKey, TValue> dictionary)
            {
                this.dictionary = dictionary;
                currentKey = default(TKey);
            }

            public Pair<TKey, TValue> Current
            {
                get
                {
                    currentKey = dictionary.Keys[index];
                    currentValue = dictionary.Values[index];
                    return new Pair<TKey, TValue>(currentKey, currentValue);
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (EqualityComparer<TKey>.Default.Equals(currentKey, default(TKey)))
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
                return index < dictionary.Keys.Count;
            }

            public void Reset()
            {
            }
        }
    }
}
