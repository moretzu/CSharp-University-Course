using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {   // Implicit Type Conversion
            {
                byte b = 1;
                int i = b;
            }

            // Explicit Type Conversion
            {
                int i = 3000;
                byte b = (byte)i;  // 184, data loss is happening here
            }

            {
                float f = 1.0f;
                int i = (int)f;
            }

            // Non-compatible types
            {
                string s = "1";
                int i = Convert.ToInt32(s);
                int j = int.Parse(s);
            }
        }
    }
}
