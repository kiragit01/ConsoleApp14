using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1) Выполнить инициализацию одномерного массива с использованием конструктора
            //без указания значений элементов, заполнить массив с клавиатуры и вывести на экран.

            Console.Write("Введите размер массива = ");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"massive[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0;i < count; i++)
                Console.WriteLine($"massive[{i}] = {array[i]}");


            //2) Инициализировать одномерный массив с использованием конструктора,
            //без указания размерности массива и без клавиатуры. 

            int[] array1;

            //3) Заполнить одномерный массив соответствующими индексами(по формуле)
            //и вывести с использованием цикла foreach.

            Console.Write("Введите размер массива = ");
            int count1 = int.Parse(Console.ReadLine());
            int[] array2 = new int[count1];
            for (int i = 0; i < count1; i++)
                array2[i] = i;
            foreach (int i in array2)
                Console.WriteLine(i);

            //4) Заполнить одномерный массив случайным образом
            //и вывести на экран с использованием цикла foreach.

            Random random = new Random();
            int count2 = random.Next(100);
            int[] array3 = new int[count2];
            for (int i = 0; i < count2; i++)
            {
                array3[i] = random.Next(1000);
            }
            foreach (int i in array3)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
