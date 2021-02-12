using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            string x;

            Console.WriteLine("Введите пять чисел: ");


            for (int i = 0; i <= 4; i++)
            {
                x = Console.ReadLine();
                s += Convert.ToInt32(x);
            }

            Console.WriteLine($"Сумма: {s}");
        }
    }
}
