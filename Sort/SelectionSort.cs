using System;
using System.Linq;


namespace AdvancedAlogrithms
{
    internal class Program
    {
        public static void SelectionSort(ref int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return;

            int length = arr.Length;

            int minIndex = 0;

            for (int i = 0; i < length - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[minIndex] > arr[j])
                        minIndex = j;
                }

                if (i != minIndex)
                    (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine($"Array elements before sorting : {string.Join(", ", arr ?? Enumerable.Empty<int>())}\n");

            SelectionSort(ref arr);

            Console.WriteLine($"Array elements after sorting : {string.Join(", ", arr ?? Enumerable.Empty<int>())}\n");


            Console.ReadKey();
        }

    }
}
