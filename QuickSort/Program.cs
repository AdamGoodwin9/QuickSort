using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 6, 5, 1, 3, 8, 4, 7, 9, 2 };
            QuickSort(list);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }


        static void QuickSort(List<int> list)
        {
            QuickSort(list, 0, list.Count - 1);
        }

        static void QuickSort(List<int> list, int left, int right)
        {
            if (list.Count <= 1 || right - left <= 1)
            {
                return;
            }

            int wall = left;

            for (int i = wall; i <= right; i++)
            {
                if (list[i] < list[right])
                {
                    int temp = list[i];
                    list[i] = list[wall];
                    list[wall] = temp;
                    wall++;
                }

                if (i == right)
                {
                    int temp = list[right];
                    list[right] = list[wall];
                    list[wall] = temp;
                }
            }

            QuickSort(list, left, wall - 1);
            QuickSort(list, wall, right);
        }
    }
}