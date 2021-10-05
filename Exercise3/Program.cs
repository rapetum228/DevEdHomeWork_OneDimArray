using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс минимального элемента массива");
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]} ");
            }

            int minElementArr = 0;
            int indexMin = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (minElementArr > arr[i])
                {
                    minElementArr = arr[i];
                    indexMin = i;
                }

            }
            Console.Write($"\n\n{indexMin} - индекс минимального элемента массива");
        }
    }
}
