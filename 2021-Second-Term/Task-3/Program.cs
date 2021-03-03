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

            var mainDiagonal = "";
            for (var i = 0; i < matrice.GetLength(0); i++)
            for (var j = 0; j < matrice.GetLength(1); j++)
            {
                if (i != j) continue;

                if (i + 1 == n && j + 1 == n)
                    mainDiagonal += $"{matrice[i, j]}";
                else
                    mainDiagonal += $"{matrice[i, j]} | ";
            }

            // Транспонируем матрицу
            for (var i = 1; i < n; i++)
            for (var j = 0; j < i; j++)
            {
                matrice[i, j] ^= matrice[j, i];
                matrice[j, i] ^= matrice[i, j];
                matrice[i, j] ^= matrice[j, i];
            }

            // Вернём в матрицу главную ось
            var c = 0;
            for (var i = 0; i < matrice.GetLength(0); i++)
            for (var j = 0; j < matrice.GetLength(1); j++)
            {
                if (i != j) continue;

                matrice[i, j] = Convert.ToInt32(mainDiagonal.Split(" | ")[c]);
                c++;
            }

            Console.WriteLine("Транспонированная матрица: ");
            PrintMatrice(matrice);

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