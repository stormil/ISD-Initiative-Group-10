using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    public class ArrayList
    {
        private object[] items;
        public object this[int index]
        {
            get
            {
                CheckIndex(index);
                return items[index];
            }
            set => Add(value);
        }

        public int Count => items.Length;

        public void Add(object value)
        {
            Insert(items.Length, value);
        }

        public void Clear()
        {
            items = new object[0];
        }

        public bool Contains(object value)
        {
            foreach (object item in items)
            {
                if (value == item)
                {
                    return true;
                }
            }
            return false;
        }

        //public void CopyTo(Array array, int index)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        public int IndexOf(object value)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(value))
                {
                    return i;
                }
            }
            throw new ArgumentException();
        }
        public void Insert(int index, object value)
        {
            CheckIndex(index);
            object[] temporary = new object[items.Length + 1];
            for (int i = 0, j = 0; i < temporary.Length; i++, j++)
            {
                if (i == index)
                {
                    temporary[i] = value;
                    i++;
                }
                temporary[i] = items[j];
            }
            items = temporary;
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index);
            object[] temporary = new object[items.Length - 1];
            for (int i = 0, j = 0; i < temporary.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                temporary[i] = items[j];
            }
            items = temporary;
        }
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new ArgumentException();
            }
        }
    }
}
