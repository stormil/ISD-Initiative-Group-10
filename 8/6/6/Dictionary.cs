using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Dictionary<TKey, TValue>
    {
        private struct Node
        {
            public TKey tkey;
            public TValue tvalue;
        }
        List<Node> Nodes = new List<Node>();
        public void Add(TKey key, TValue value)
        {
            Node node = new Node
            {
                tkey = key,
                tvalue = value
            };
            Nodes.Add(node);
            count++;
        }
        public TValue this[int index]
        {
            get
            {
                return Nodes[index].tvalue;
            }
        }
        private int count;

        public int Count { get => count;}
    }
}
