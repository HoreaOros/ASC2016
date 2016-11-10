using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.001;

            double suma = 0;

            

            for (int i = 0; i < 1000000; i++)
            {
                suma = suma + eps;
                //Console.WriteLine("{0} ", suma);
                //Console.ReadKey();
            }
            Console.WriteLine("Suma este: {0}", suma);
        }
    }
}
