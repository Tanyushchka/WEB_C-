using System;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string c = Console.ReadLine();

            int count = 0;
            string slovo = "";

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != ' ')
                {
                    count++;
                }
                
            }
          
            string[] word = c.Split(new char[] {' '});

            for (int i = 0; i < word.Length; i++)
            {
                slovo += word[i][word[i].Length - 1];
            }

            Console.WriteLine("Количество слов: " + word.Length + ";");
            Console.WriteLine("Количество символов без пробелов: " + count + ";");
            Console.WriteLine("Соотношение количество символов без пробелов к количеству слов: " + (double)count/ word.Length + ";");
            Console.WriteLine("Слово из последних символов слов: " + slovo + ";");
            
        }
    }
}