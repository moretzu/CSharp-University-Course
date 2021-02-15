using System;
using System.Collections.Generic;
using System.Linq;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализируем генератор случайных чисел
            Random randomizer = new Random();
            List<double> array = new List<double>();

            // Заполним список пятью случайными числами со значениями от 1 до 10
            for (int i = 0; i < 5; i++)
                array.Add(randomizer.Next(1, 10));


            Console.WriteLine("Элементы списка: {0}.", String.Join(", ", array));

            // Получим ср. значение через LINQ
            double avg = array.Average();
            Console.WriteLine($"Среднее значение: {avg}.");
        }
    }
}
