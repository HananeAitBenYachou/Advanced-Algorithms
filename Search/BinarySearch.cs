using System;

namespace AdvancedAlogrithms
{
    internal class Program
    {
        public static int BinarySearch(int[] arr, int number)
        {
            int start = 0;
            int end = arr.Length - 1;

            int middle = 0;

            while (start <= end)
            {
                middle = start + (end - start) / 2;

                //check if the target element is present in the middle
                if (number == arr[middle])
                    return middle;

                //if it is smaller , we ignore the right half 
                if (number < arr[middle])
                    end = middle - 1;

                //if it is greater , we ignore the left half 
                else
                    start = middle + 1;
            }

            return -1; // if we reach here , then the target element is not found
        }

        static void Main(string[] args)
        {
            int[] arr = { 22, 25, 37, 41, 45, 46, 49, 51, 55, 58, 70, 80, 82, 90, 95 }; // Sorted array

            int number = 45; // Element to be searched

            Console.WriteLine("Sorted Array:");

            foreach (var item in arr)
                Console.Write(item + " ");

            Console.WriteLine();

            int result = BinarySearch(arr, number);

            if (result == -1)
                Console.WriteLine("Element not found in the array.");
            else
                Console.WriteLine("Element found at index: " + result);


            Console.ReadKey();
        }
    }
}