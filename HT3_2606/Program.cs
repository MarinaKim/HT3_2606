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

            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < index2; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = index2; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
            arr = newArr;
            foreach (int item in arr)
                Console.Write("{0}\t", item);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("введите число, которое хотите удалить: ");
            int k = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < arr.Length; i++)
            {
               if (arr[i] == k)
                {
                    int[] tmp = new int[arr.Length - 1];
                    for (int j=0;j<i;j++)
                    {
                        tmp[j] = arr[j];
                    }
                    for(int j=i;j<tmp.Length;j++)
                    {
                        tmp[j] = arr[j + 1];
                    }
                    arr = tmp;
                }
            }
            foreach (int item in arr)
                Console.Write("{0}\t", item);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");


            Console.Write("Введите индекс, куда хотите вставить элемент: ");
            index2 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите элемент: ");
            int el = Int32.Parse(Console.ReadLine());
            int[] tmp1 = new int[arr.Length + 1];
            for (int i = 0; i < index2; i++)
            {
                tmp1[i] = arr[i];
            }
            tmp1[index2] = el;
            for(int i = index2 + 1; i < tmp1.Length; i++)
            {
                tmp1[i] = arr[i-1];
            }
            
            foreach (int item in tmp1)
                Console.Write("{0}\t", item);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
