using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    static class Sorter
    {
        public static void SortQuick(this int[] a, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = Partition(a, left, right);

            if (index != -1)
            {
                SortQuick(a, left, index - 1);
                SortQuick(a, index + 1, right);
            }
        }

        private static int Partition(int[] A, int left, int right)
        {
            if (left > right) return -1;

            int end = left;

            int pivot = A[right];
            for (int i = left; i < right; i++)
            {
                if (A[i] < pivot)
                {
                    Swap(A, i, end);
                    end++;
                }
            }

            Swap(A, end, right);

            return end;
        }

        private static void Swap(int[] A, int left, int right)
        {
            int tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }
    }
}
