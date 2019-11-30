using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int size = 20;
            int[] arr = new int[size];
            for (int i = 0; i <size; i++)
            {
                arr[i] = random.Next(1, 30);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите max, если хотите отсортировать по возрастанию или min, если по убыванию");
            string sort = Console.ReadLine();

            int tmp;
            if (sort == "max")
            {   
                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 1; j > i; j--)
                    {
                        if (arr[j - 1] < arr[j])
                        {
                            tmp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = tmp;
                        }
                
                    }
                }
            } 
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 1; j > i; j--)
                    {
                        if (arr[j - 1] > arr[j])
                        {
                            tmp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = tmp;
                        }
                    }
                }
            }
           
            for (int j = 0; j < size; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}