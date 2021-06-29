using System;
using bubble_sort.interfaces;

namespace bubble_sort.Services
{
    public class BubbleSortService : ISort
    {
        public void PrintArray(int[] array)
        {
             int n = array.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public void SortArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
            Console.WriteLine("Array sorted");
        }
    }
}