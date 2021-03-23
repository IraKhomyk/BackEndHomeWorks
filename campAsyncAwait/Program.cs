using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace campAsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {

            List<int> array = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                var n = new Random().Next(-100, 100);

                array.Add(n);

            }
            List<int> firstArray = new List<int>();
            List<int> secondArray = new List<int>();

            for (int i = 0; i < array.Count/2; i++)
            {
                firstArray.Add(array[i]);
                secondArray.Add(array[i + (array.Count / 2)]);

            }

            Console.WriteLine("Arrays are sorting...");

            var sortFirstArray =  Task.Run(() => SortArray(firstArray));

            var sortSecondArray = Task.Run(() => SortArray(secondArray));
            sortSecondArray.Start();

            await Task.WhenAll(sortFirstArray, sortSecondArray);

            Console.WriteLine("Sorting of all parts done");

            PrintArray(firstArray);

            Console.WriteLine();

            PrintArray(secondArray);

        }

        static List<int> SortArray(List<int> arr)
        {
            arr.Sort();
            Console.WriteLine("The array is sorted");
            return arr;
        }

        static void PrintArray(List<int> arr)
        {
            Console.WriteLine("The  sorted array:");

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
