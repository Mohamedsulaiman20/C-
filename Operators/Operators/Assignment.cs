using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Assignment : operators
    {
        public void assignment()
        {
           // operators myObj = new Assignment();

            Console.WriteLine(x += 5);//assignment operators
            Console.WriteLine(x -= 5);
            Console.WriteLine(x *= 5);
            Console.WriteLine(x /= 5);
            Console.WriteLine(x %= 5);
            Console.WriteLine(x &= 5);
            Console.WriteLine(x |= 5);
            Console.WriteLine(x ^= 5);
            Console.WriteLine(x >>= 5);
            Console.WriteLine(x <<= 5);

        }
        
    }
}
