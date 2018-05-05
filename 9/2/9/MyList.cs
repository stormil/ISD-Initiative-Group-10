using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{

    class MyList<T> : IEnumerable<T>
    {
        private class Node
        {
            public T info;
            public Node next;
            public int index;
        }
        private Node begin;
        private int current;
        public void Add(T value)
        {
            Node temp = new Node()
            {
                info = value
            };
            temp.next = begin;
            begin = temp;
            temp.index = count;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = begin;
            while (current != null)
            {
                yield return current.info;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public MyList()
        {
            Node temp = new Node
            {
                next = begin
            };
            begin = null;
            count = 0;
            current = -1;
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                Node temp = begin;
                while (temp != null)
                {
                    if (temp.index == index)
                    {
                        break;
                    }
                }
                return temp.info;
            }
        }
       
    }
}
