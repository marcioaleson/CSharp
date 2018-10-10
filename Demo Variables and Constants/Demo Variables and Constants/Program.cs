using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Variables_and_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'M';
            string firstName = "Márcio";
            bool isWorking = false;
            const float Pi = 3.14f;
            var test = 1;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(test);
            Console.WriteLine("Pi value {0}", Pi);
            //Primitive Types
            Console.WriteLine("Max byte {0} and Min {1}",byte.MaxValue,byte.MinValue);
            Console.WriteLine("Max int {0} and Min {1}", int.MaxValue, int.MinValue);
            Console.WriteLine("Max float {0} and Min {1}", float.MaxValue, float.MinValue);
            Console.WriteLine("Max double {0} and Min {1}", double.MaxValue, double.MinValue);
            Console.WriteLine("Max deciaml {0} and Min {1}", decimal.MaxValue, decimal.MinValue);
            Console.WriteLine("Max long {0} and Min {1}", long.MaxValue, long.MinValue);
            Console.WriteLine("Max ulong {0} and Min {1}", ulong.MaxValue, ulong.MinValue);

            Console.Read();
        }
    }
}
