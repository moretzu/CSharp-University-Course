/*
 * Дан массив А ненулевых целых чисел размера 10. Вывести значение первого из тех его элементов Ак,
 * которые удовлетворяют неравенству Ак< А10. Если таких элементов нет, то вывести 0, оформить в
 * виде процедуры. В основной программе организовать ввод и вывод массива, и вывод найденного значения.  
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_4_Coroutines_And_Functions {
    public static class Program {
        // Функция для заполнения массива
        private static void ReadElements(IList<int> arr) {
            Console.WriteLine("Пожалуйста, введите 10 элементов массива (целые числа):");

            for (var i = 0; i < 10; i++) {
                var inp = Console.ReadLine();
                var num = Convert.ToInt32(inp);

                arr[i] = num;
            }
        }

        // Функция для вывода элементов массива
        private static void PrintElements(IEnumerable<int> arr) {
            var elements = string.Join(", ", arr);
            Console.WriteLine($"Элементы массива: [{elements}]");
        }

        // Функция поиска нужного элемента через логическое выражение
        private static void FindByExpression(IEnumerable<int> arr, Func<int, bool> predicate) {
            var res = arr.FirstOrDefault(predicate);
            Console.WriteLine($"Искомый элемент: {res}");
        }

        private static void Main() {
            var a = new int[10];

            ReadElements(a);
            PrintElements(a);
            FindByExpression(a, num => num < a[9]);
        }
    }
}