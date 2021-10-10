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
            /*
             Открывается цикл от 0 до конца по i. Элемент массива с номером i сравнивается
            с последующими элементами от i до N. Если какой-то из элементов в промежутке больше 
            (в случае сортировки по убыванию), то этот элемент заменяет текущий с номером i, 
            а текущий становится на место того элемента. 

             */
            for (int j = 0; j < arr.Length; j++)
            {
                int minElementArr = arr[arr.Length-1 - j];
                int maxElementArr = arr[j];
                int indexMax = j;
                int indexMin = arr.Length - 1 - j;
                int tempMax = arr[j];
                int tempMin = arr[arr.Length - 1 - j];
                int tillMax = j;
                int fromMin = arr.Length-1-j;
                while (fromMin >= j && tillMax < arr.Length-j)
                {
                    
                    if(maxElementArr <= arr[tillMax])
                    {
                        maxElementArr = arr[tillMax];
                        indexMax = tillMax;
                    }
                    if (minElementArr >= arr[fromMin])
                    {
                        minElementArr = arr[fromMin];
                        indexMin = fromMin;
                    }
                    tillMax++;
                    fromMin--;
                }
                
                arr[j] = maxElementArr;
                arr[arr.Length - 1 - j] = minElementArr;
                arr[indexMax] = tempMax;
                arr[indexMin] = tempMin;
                
            }

                for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
    }
}
