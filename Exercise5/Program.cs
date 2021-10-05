using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать сумму элементов массива с нечетными индексами\n");
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];

            int sumOddIndex = 0;
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]} ");
                if ( (i+1) % 2 == 1)
                {
                    sumOddIndex += arr[i];
                }
            }
            Console.WriteLine($"\n\nРезультат: {sumOddIndex}\n");
        }
    }
}
