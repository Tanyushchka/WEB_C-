using System;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Введите две переменные: ");
            string[] inp = Console.ReadLine().Split(' ');

            int a, b;
            int.TryParse(inp[0], out a);
            int.TryParse(inp[1], out b);

            Console.WriteLine(5 + Math.Sin(a / 3 + b / 6) * Math.Sqrt(a - 2));
            Console.WriteLine(Math.Sqrt(Math.Pow(b, 3) + 5 / (b + 2)) - Math.Sqrt(a));
            Console.WriteLine(Math.Pow(a, 2) + Math.Pow(b, 4) / (a - 2));
            Console.WriteLine(Math.Cos(b * 4) * Math.Cos(a + 1) / 2 - Math.Cos(b - 2) * 3 / 4);
         
        }
    }
}