using System;
using bubble_sort.Services;

namespace thread_in_motion_case_studies
{
    class Program
    {
        public static void Main()
        {
            int[] array = { 11, 93, 45, 98, 13, 55 };
            BubbleSortService sortService = new BubbleSortService();
            sortService.SortArray(array);
            sortService.PrintArray(array);
        }
    }
}
