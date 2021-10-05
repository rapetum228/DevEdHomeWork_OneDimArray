using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отсортировать массив по возрастанию одним из способов:  " +
                "пузырьком(Bubble), выбором (Select) или вставками (Insert))");
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];

            //int[] arr = { 1, 2, -4, 0, 6, 3};

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("\nСортировка пузырьком:");

            int countExchange = 1;
            while (countExchange != 0)
            {
                countExchange = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int firstOfPair, secondOfPair;
                    firstOfPair = arr[j];
                    secondOfPair = arr[j + 1];

                    if (secondOfPair < firstOfPair)
                    {
                        arr[j] = secondOfPair;
                        arr[j + 1] = firstOfPair;
                        countExchange++;
                    }
                }
                Console.WriteLine("Количество обменов: " + countExchange + " из " + arr.Length);
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]}\t");
            }
        }
    }
}
