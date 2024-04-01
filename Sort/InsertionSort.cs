using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Advanced_Algorithms
{
    internal class Program
    {
        public static void InsertionSort(int[] numbers)
        {
            //No need to perform any sorting if the input array is either null , or has less than two elements
            if (numbers == null || numbers.Length <= 1)
                return;

            int key;

            for (int i = 1; i < numbers.Length; i++)
            {
                key = numbers[i];

                //Start from the sorted segment of the array
                int j = i - 1;

                //Shift the elements greater than the key to the right 
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                //Insert the key in its correct position
                numbers[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine($"Array Elements before the sorting : {string.Join(", ", numbers)} ");

            InsertionSort(numbers);

            Console.WriteLine($"Array Elements after the sorting : {string.Join(", ", numbers)} ");

            Console.ReadKey();
        }
    }
}
