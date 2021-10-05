using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Найти максимальный элемент массива\n");
            Console.WriteLine("Введите размер массива");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]} ");
            }

            int maxElementArr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxElementArr < arr[i])
                {
                    maxElementArr = arr[i];
                }

            }
            Console.Write($"\n\n{maxElementArr} - максимальный элемент массива");
        }
    }
}
