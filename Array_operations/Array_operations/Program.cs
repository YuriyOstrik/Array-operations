using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 3, 8, 1, 2 }; 
            int[] array2 = { 7, 6, 4 };
            Console.WriteLine("Исходный массив:");
            PrintArray(array1); 
            SortArrayAscending(array1);
            Console.WriteLine("Сортировка по возрастанию:"); 
            PrintArray(array1);
            SortArrayDescending(array1); 
            Console.WriteLine("Сортировка по убыванию:");
            PrintArray(array1);
            int[] mergedArray = MergeArrays(array1, array2);
            Console.WriteLine("Объединенный массив:");
            PrintArray(mergedArray);
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            int result = CalculateAbsoluteDifference(n); 
            Console.WriteLine($"Результат: {result}");
        }
        static int CalculateAbsoluteDifference(int n)
        {
            int difference = Math.Abs(n - 123); if (n > 123) { return 3 * difference; }
            return difference;
        }
        static void PrintArray(int[] array) 
        { 
            Console.WriteLine(string.Join(", ", array));
        }
        static void SortArrayAscending(int[] array) 
        { 
            Array.Sort(array); 
        }
        static void SortArrayDescending(int[] array) 
        { 
            Array.Sort(array); Array.Reverse(array);
        }
        static int[] MergeArrays(int[] array1, int[] array2) 
        { 
            int[] mergedArray = new int[array1.Length + array2.Length]; 
            Array.Copy(array1, 0, mergedArray, 0, array1.Length);
            Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length); 
            return mergedArray; 
        }

    }
}
