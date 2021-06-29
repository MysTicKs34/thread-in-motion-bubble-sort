﻿using System;

namespace thread_in_motion_case_studies
{
    class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void Main()
        {
            int[] arr = { 11, 93, 45, 98, 13, 55 }; 
            BubbleSort(arr);
            Console.WriteLine("Sorted array");
            PrintArray(arr);
        }
    }
}
