using System;


namespace AdvancedAlogrithms
{
    internal class Program
    {
        public static void BubbleSort(ref int[] arr)
        {
            for(int i=0; i< arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                }
            }

        }

        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            BubbleSort(ref arr);

            Console.WriteLine("\nSorted array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

    }
}
