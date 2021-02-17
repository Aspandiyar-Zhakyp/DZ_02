using System;

namespace DZ_02_Practice_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расстояние в сантиметрах: ");
            double smetres = Double.Parse(Console.ReadLine());

            double metres = smetres * .001;

            Console.WriteLine("Расстояние в метрах: " + metres);

            Console.ReadLine();
        }
    }
}
