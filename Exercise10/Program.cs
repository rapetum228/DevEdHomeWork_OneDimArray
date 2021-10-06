using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отсортировать массив по убыванию одним из способов: " +
                "пузырьком(Bubble), выбором (Select) или вставками (Insert))");
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
            Console.WriteLine("\nСортировка выбором:");
            
            for (int j = 0; j < arr.Length; j++)
            {
                int maxElementArr = arr[j];
                int indexMax = j;
                int temp = arr[j];
                for (int i = j; i < arr.Length; i++)
                {
                    if (maxElementArr < arr[i])
                    {
                        maxElementArr = arr[i];
                        indexMax = i;
                    }

                }
                arr[j] = maxElementArr;
                arr[indexMax] = temp;

            }

                for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
    }
}
