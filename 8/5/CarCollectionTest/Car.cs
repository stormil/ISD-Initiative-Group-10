using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollectionTest
{
    class Car
    {
        public string Mark { set; get; }
        public int ProductYear { set; get; }

        public override string ToString()
        {
            return $"Mark: {Mark}\n" +
                $"Product year: {ProductYear}";
        }
    }
}
