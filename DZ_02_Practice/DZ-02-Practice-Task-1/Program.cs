using System;

namespace DZ_02_Practice_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения: y = 7x^2 - 3x + 4");
            Console.WriteLine("Введите X: ");
            int x = Int32.Parse(Console.ReadLine());

            int pow2 = x * x;
            int result = (7 * pow2) - (3 * x) + 4;

            Console.WriteLine("Результат: " + result);

            Console.ReadLine();
        }
    }
}
