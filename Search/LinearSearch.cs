using System;


namespace AdvancedAlogrithms
{
    internal class Program
    {
        public static int LinearSearch(int[] arr, int number)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == number)
                    return i; //Here is the target element is found , so we return its index
            }

            return -1; //The target element is not found , hence -1 is returned
        }

        static void Main(string[] args)
        {
            int[] arr = { 22, 25, 37, 41, 45, 46, 49, 51, 55, 58, 70, 80, 82, 90, 95 }; // Sorted array

            int number = 50; // Element to be searched

            foreach (var item in arr)
                Console.Write(item + " ");

            Console.WriteLine();

            int result = LinearSearch(arr, number);

            if (result == -1)
                Console.WriteLine("Element not found in the array.");
            else
                Console.WriteLine("Element found at index: " + result);


            Console.ReadKey();
        }

    }
}
