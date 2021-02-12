﻿using System;

namespace Third
{
    class Program
    {
        static void PrintMatrice(int[,] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}");

                    if (j + 1 != arr.GetLength(1))
                        Console.Write(" ");
                }

                if (i + 1 != arr.GetLength(0))
                    Console.Write("\n");
            }
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            Random r = new Random();

            Console.Write("Укажите размер квадратной матрицы (одно число): ");

            string inp = Console.ReadLine();
            int n = Convert.ToInt32(inp);

            // Подготовим объект матрицы
            int[,] matrice = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrice[i, j] = r.Next(1, 10);
                }
            }

            Console.WriteLine("Исходная матрица: ");
            PrintMatrice(matrice);

            int s = 0;
            for (int i = 0; i < matrice.GetLength(0); i++)
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (i == j) s += matrice[i, j];
                }

            Console.WriteLine($"Сумма элементов главной оси: {s}");

            int[,] invertedMatrice = new int[n, n];
            for (int i = 0; i < matrice.GetLength(0); i++)
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (i != j)
                        invertedMatrice[i, j] = matrice[j, i];
                    else
                        invertedMatrice[i, j] = matrice[i, j];
                }

            Console.WriteLine("Транспонированная матрица (главная ось сохранена)");
            PrintMatrice(invertedMatrice);
        }
    }
}
