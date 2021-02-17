using System;
using System.Text;

namespace Third
{
    class Program
    {
        static void PrintMatrice(int[,] arr)
        {
            var toWrite = new StringBuilder();
            var rowLength = arr.GetLength(0);
            var colLength = arr.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    toWrite.Append($"{arr[i, j]} ");
                }

                toWrite.Append('\n');
            }

            Console.Write(toWrite.ToString());
        }

        static void Main(string[] args)
        {
            // Подготовим генератор случайных чисел
            var r = new Random();

            Console.Write("Укажите размер квадратной матрицы (одно число): ");

            var inp = Console.ReadLine();
            var n = Convert.ToInt32(inp);

            // Сгенерируем матрицу (2-х мерный массив) указанного размера
            var matrice = new int[n, n];

            for (var i = 0; i < n; i++)
            for (var j = 0; j < n; j++)
                matrice[i, j] = r.Next(1, 10);

            Console.WriteLine("Исходная матрица: ");
            PrintMatrice(matrice);

            // Создадим объект транспонированной матрицы и заполним его
            // учитвая, что главная диагональ не должна изменяться
            var invertedMatrice = new int[n, n];
            for (var i = 0; i < matrice.GetLength(0); i++)
            for (var j = 0; j < matrice.GetLength(1); j++)
                if (i != j)
                    invertedMatrice[i, j] = matrice[j, i];
                else
                    invertedMatrice[i, j] = matrice[i, j];

            Console.WriteLine("Транспонированная матрица (главная ось сохранена)");
            PrintMatrice(invertedMatrice);

            // Перменная-счётчик для вычисления суммы элементов
            // главной диагонали исходной матрицы
            var s = 0;
            for (var i = 0; i < matrice.GetLength(0); i++)
            for (var j = 0; j < matrice.GetLength(1); j++)
                if (i == j)
                    s += matrice[i, j];

            Console.WriteLine($"Сумма элементов главной оси: {s}");
        }
    }
}