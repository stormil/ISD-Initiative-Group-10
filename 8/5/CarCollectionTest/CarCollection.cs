using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollectionTest
{
    class CarCollection<T>
    {
        private List<T> collectoin;

        public int Count { private set; get; }

        public CarCollection()
        {
            Count = 0;
            collectoin = new List<T>();
        }

        public void Add(T item)
        {
            collectoin.Add(item);
            Count++;
        }

        public void ClearPark()
        {
            collectoin.Clear();
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                return collectoin[index]; 
            }
        }
    }
}
