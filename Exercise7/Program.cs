using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать количество нечетных элементов массива");
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];

            int itemArrOdd = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]} ");
                if (arr[i]%2 != 0)
                {
                    itemArrOdd++;
                }
            }

            Console.WriteLine($"\n\nКоличество нечётных элементов массива: {itemArrOdd} \n");
        }
    }
}
