using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace BitOperators
{
    class Program
    {
        static void Main(string[] args)
        {


            uint b = 0xff;
            Console.WriteLine(Base2(b));

            uint b1 = Set(b, 27);
            Console.WriteLine(Base2(b1));

            uint b2 = Reset(b, 27);
            Console.WriteLine(Base2(b2));
            Console.ReadKey();
        }

        private static string Base2(uint b)
        {
            string s2 = Convert.ToString(b, 2);
            
            
            // primul argument reprezinta lungimea totala a sirului care va rezulta. 
            // Functia PadLeft calculeaza automat numarul de zerouri care se adauga in functie de lungimea sirului original. 
            s2 = s2.PadLeft(32, '0'); 
            
            return s2;
        }

        private static uint Reset(uint b, int v)
        {
            return b & ~(1u << v);
        }

        private static uint Set(uint b, int v)
        {
            return b | (1u << v);
        }
    }
}
