using System;

namespace Overflowing
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort number = UInt16.MaxValue;
            number++; // turns into 0

            Console.WriteLine(number);

            int number2 = Int32.MaxValue;
            number2++; // turns into -2147483648

            Console.WriteLine(number2);

            // wrapping in checked will prevent overflows
            // but instead will throw an exception during runtime
            checked
            {
                byte number3 = 255;
                number3++;
            }
        }
    }
}
