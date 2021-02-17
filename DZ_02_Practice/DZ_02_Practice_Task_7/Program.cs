using System;

namespace DZ_02_Practice_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 456;
            Console.WriteLine("Исходное исло: " + number);

            int hund = number / 100;
            int half = number / 10;
            int dec = half % 10;
            int unt = number % 10;

            Console.WriteLine("Число: " + hund + unt + dec);

            Console.ReadLine();
        }
    }
}
