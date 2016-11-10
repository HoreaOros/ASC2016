using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int delta = 1000000;

            //while (true)
            //{
            //    suma += delta;
            //    Console.WriteLine("{0}", suma);
            //}

            int a = 2000000000;
            int b = 2000000000;
            int c;
            try
            {
                checked
                {
                    c = a + b;
                }
                Console.WriteLine("{0} + {1} = {2}", a, b, c);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
