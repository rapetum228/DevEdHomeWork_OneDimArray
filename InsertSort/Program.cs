using System;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка массива вставками по возрастанию\n");
            /*
             Берётся iый элемент массива и проверяется меньше ли он каких-либо элементов
            с индексами до i. Если да, то он вставляется перед элементом, которого он меньше.
            Иначе остаётся на своём месте. По сути, вроде как сортировка выбором, только наоборот.
             */
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];
           
            //int[] arr = { 2, 1, 3, 0 };
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]}\t");
            }


            for (int i = 0; i < arr.Length; i++)
            {
                
                int temp = arr[i];
                int index = i;
                for (int j = i-1; j >= 0; j--)
                {

                    if (temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
              
            }

            Console.WriteLine("\nОтсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }

        }
    }
}
