using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            var d = 10;
            float e = 3.2f;
            bool f = true;
            bool g = false;

            Console.WriteLine(a + b);
            Console.WriteLine(b - a);
            Console.WriteLine(d / c);
            Console.WriteLine(e - a);
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == a);
            Console.WriteLine(a != a);
            Console.WriteLine(f | g);
            Console.WriteLine(f && g);
            Console.WriteLine(!(a == a));
            Console.Read();
        }
    }
}
