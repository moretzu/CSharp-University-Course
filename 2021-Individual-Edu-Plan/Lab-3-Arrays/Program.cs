/*
 * Дан массив А ненулевых целых чисел размера 10.
 * Вывести значение первого из тех его элементов
 * Ак, которые удовлетворяют неравенству Ак< А10.
 * Если таких элементов нет, то вывести 0. 
 */

using System;
using System.Linq;

namespace Lab_3_Arrays {
    class Program {
        // Функция, генерирующая массив из 10 случайных чисел
        private static int[] MakeArray() {
            var r = new Random();
            var arr = new int[10];

            for (var i = 0; i < 10; i++)
                arr[i] = r.Next(1, 100);

            return arr;
        }

        private static void Main() {
            // Сгенерируем массив
            var a = MakeArray();
            // Выведем его значения
            Console.WriteLine($"Дан массив: [{string.Join(", ", a)}]");

            // Найдем требуемые элемент

            // Если такого элемента нет,
            // то значение result будет 0
            var result = a.FirstOrDefault(num => num < a[9]);
            // Выведем результат
            Console.WriteLine($"Результат: {result}");
        }
    }
}