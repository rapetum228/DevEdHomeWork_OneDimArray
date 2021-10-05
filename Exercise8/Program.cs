﻿using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поменять местами первую и вторую половину массива, " +
                "например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.\n");

            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]}\t");
            }
            int unitOrNull = 0;
            if (arr.Length%2 == 0) 
                unitOrNull = 0;
            
            else
                unitOrNull = 1;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length / 2 + i + unitOrNull];
                arr[arr.Length / 2 + i + unitOrNull] = temp;
            }

            Console.WriteLine("\nНовый массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
    }
}
