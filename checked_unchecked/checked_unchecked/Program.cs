using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            byte a, b, result;
            Console.Write("Введите количество опросов: ");
            int i = int.Parse(Console.ReadLine());

            for (int j = 1; j <= i; j++)
            {
                try
                {
                    Console.Write("Введите a: ");
                    // Используем unchecked в одном выражении
                    a = unchecked((byte)int.Parse(Console.ReadLine()));
                    Console.Write("Введите b: ");
                    b = unchecked((byte)int.Parse(Console.ReadLine()));

                    // Используем checked для всего блока операторов
                    checked
                    {
                        result = (byte)(a + b);
                        Console.WriteLine("a + b = " + result);
                        result = (byte)(a * b);
                        Console.WriteLine("a*b = " + result + "\n");
                    }
                }
                catch (OverflowException)
                {
                    Console.Write("Переполнение\n\n");
                }
            }
            Console.ReadLine();
        }
    }
}