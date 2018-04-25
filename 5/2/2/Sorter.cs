using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    static class Sorter
    {
        static public int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {  
                    int temp = array[right];
                    array[right] = array[left];
                    array[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void SortQuick(this int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    SortQuick(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    SortQuick(array, pivot + 1, right);
                }
            }
        }
    }
}
