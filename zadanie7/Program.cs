using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    internal class Program
    {
        static int[] Zadanie7(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                Zadanie7(array, leftIndex, j);
            if (i < rightIndex)
                Zadanie7(array, i, rightIndex);
            return array;
        }
        static void Main(string[] args)
        {
            int[] x = { 4, 2, 3, 1, 6, 2, 7 };
            x = Zadanie7(x, 0, 6);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
