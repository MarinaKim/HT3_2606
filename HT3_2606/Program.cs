using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT3_2606
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 15, 6, 7, 2 };
            Console.WriteLine("Напечатать весь массив целых чисел:");
            foreach (int item in arr)
                Console.Write("{0}\t", item);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");

            int max = arr.Max();
            int index = Array.LastIndexOf(arr, max);
            Console.WriteLine("Найти индекс максимального значения в массиве: {0}", index);
            Console.WriteLine("----------------------------------------------------------");


            int max1 = -1;
            int index1 = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && max1 < arr[i])
                {
                    max1 = arr[i];
                    index1 = i;
                }
            }
            Console.WriteLine("Найти индекс максимального четного значения в массиве: {0}", index1);
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Enter the index: ");
            int index2 = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index2)
                {
                    Array.Clear(arr, i, 1);
                }
            }
            Console.WriteLine("Удалить элемент из массива по индексу: ");
            foreach (int item in arr)
                Console.Write("{0}\t", item);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");


          
        }
    }
}
