using System;

namespace operations
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите операцию: ");
            string oper =  Console.ReadLine();

            while (oper !=  "exit")
            {
                while ((oper !=  "+") & & (oper !=  "-") & & (oper !=  "*") & & (oper != "/"))
                {
                    Console.Write("Ошибка!");
                    Console.Write("Введите операцию: ");
                    oper =  Console.ReadLine();
                }

                int a;
                int b;
                Console.Write("Введите первое число: ");
                while (!int.TryParse( Console.ReadLine(), out a))
                {
                    Console.Write("Ошибка! Введите другое первое число: ");
                }

                Console.Write("Введите второе число: ");
                while (!int.TryParse( Console.ReadLine(), out b))
                {
                    Console.Write("Ошибка! Введите другое второе число: ");
                }

                int result =  0;
                switch (oper)
                {
                    case "+": 
                        result = a + b;
                        break;
                    case "-": 
                        result = a - b;
                        break;
                    case "*": 
                        result = a * b;
                        break;
                    case "/": 
                        if (b !== 0)
                        {
                            result = a / b; 
                            break;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            break;
                        }
                    
                }

                    Console.WriteLine(result);
                }
                Console.WriteLine("Введите exit, чтобы выйти или введите операцию, чтобы продолжить");
                oper = Console.ReadLine();
            }
        }
    }
}