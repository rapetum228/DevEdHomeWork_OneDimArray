using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс максимального элемента массива");
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

            int maxElementArr = 0;
            string indexMax = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxElementArr < arr[i])
                {
                    maxElementArr = arr[i];
                    indexMax = Convert.ToString(i);
                }
                else if (maxElementArr == arr[i])
                {
                    indexMax += ", " + Convert.ToString(i);
                }

            }
            if (indexMax.Length>1)
            {
                Console.Write($"\n\n{indexMax} - индексы максимальных элементов массива \n");
            }
            else Console.Write($"\n\n{indexMax} - индекс максимального элемента массива \n");
        }
    }
}
