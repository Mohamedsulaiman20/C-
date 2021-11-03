using System;

namespace IF_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y=30;

            if (x >= y)
            {
                Console.WriteLine("World is enough!");
            }
            else if (x <= y)
            {
                Console.WriteLine("World is not enough!");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }

            var z = x == y ? "It is Equal" : "It is not Equal";// ternary operator used instead of If and Else
            Console.WriteLine(z);
        }
    }
}
