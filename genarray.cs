using System;

namespace genarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int size, max, min;
            Console.Write("Введите размер массива: ");
            string input = Console.ReadLine();
            int.TryParse(input, out size);

            Console.Write("Введите максимальный элемент: ");
            input = Console.ReadLine();
            int.TryParse(input, out max);

            Console.Write("Введите минимальный элемент: ");
            input = Console.ReadLine();
            int.TryParse(input, out min);

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(min, max + 1);
                Console.Write(arr[i] + " ");
            }
        }
    }
}