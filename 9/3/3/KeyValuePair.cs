using System;
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
            string result = "[";
            if (Key != null) result += Key.ToString();
            result += ", ";
            if (Value != null)
            {
                result += Value.ToString();
            }
            result += "]";
            return result;
        }
    }
}
