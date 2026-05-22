/*

Create an int array of 5 numbers (user inputs them)
Write methods FindMax() and FindMin() — NO built-in Math.Max
Print the max and min values
Bonus: find the average too

*/


using System;
namespace Day_03
{
    class ArrayAnalyzer
    {
        static int FindMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        static int FindMin(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        static double FindAverage(int[] arr)
        {
            double sum = 0;
            foreach (int num in arr)
                sum += num;
            return sum / arr.Length;
        }

        static void Main()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter arr[{i}]: ");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Invalid input! Integer required.");
                    return;
                }
                arr[i] = a;
            }

            int max = FindMax(arr);
            int min = FindMin(arr);
            
            if(max == min) {
                Console.WriteLine("No max or min availlable");
                return;
            }
            
            Console.WriteLine($"\nMax value in array:     {max}");
            Console.WriteLine($"Min value in array:     {min}");
            Console.WriteLine($"Average value in array: {FindAverage(arr):F2}");
        }
    }
}