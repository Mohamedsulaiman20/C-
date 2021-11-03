using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Arithmatic : Assignment
    {
        public void arithmatic()
        {

            Console.WriteLine(x + y);//arithmetic operators
            Console.WriteLine(x -y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
            Console.WriteLine(x++);//increment
            Console.WriteLine(x--);//decrement

        }
    }
}
