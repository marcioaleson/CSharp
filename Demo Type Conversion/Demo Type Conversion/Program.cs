using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            bool a;
            var number = "1234";
            var boolean = "true";
            Console.WriteLine(i);
            //Erro
            //b = i;
            //Cast
            b = (byte)i;
            Console.WriteLine(b);
            //Erro the maximum value for bytes is 232.
            i = 1000;
            b = (byte)i;
            Console.WriteLine(b);
            //Exception
            try
            {
                b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The number can't be converted to byte.");
            }
            //Erro 
            //i = number;
            i = Convert.ToInt32(number);
            Console.WriteLine(number);

            a = Convert.ToBoolean(boolean);
            Console.WriteLine(a);

            Console.Read();
        }
    }
}
