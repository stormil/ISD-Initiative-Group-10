using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class MyList<T>
    {

        private class Node
        {
            public T info;
            public Node next;
            public int index;
        }
        private Node begin;
        public void Add(T value)
        {

            Node temp = new Node()
            {
                info = value
            };
            temp.next = begin;
            begin = temp;
            ++count;
            temp.index = count;
        }
        public MyList()
        {
            begin = null;
            count = 0;
        }
        private int count;
        public int Count
        {
            get
            {
                return Count;
            }
        }
        public T this[int index]
        {
            get
            {
                
                Node temp = begin;
                while(temp != null)
                {
                    if (temp.index == index)
                    {
                        break;
                    }
                }
                return temp.info;
                //return (T)Convert.ChangeType(temp, typeof(T));
            }
        }
    }
}
