using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperators2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint b1 = 127u;
            uint b2 = 128u;

            Console.WriteLine("b1 = {0}, b2 = {1}", b1, b2);

            

            string sb1 =  Convert.ToString(b1, 2);
            Console.WriteLine("b1 = {0} --> {1}", b1, sb1.PadLeft(32, '0'));
            string sb2 = Convert.ToString(b2, 2);
            Console.WriteLine("b2 = {0} --> {1}", b2, sb2.PadLeft(32, '0'));

            uint b3 = b1 & b2;
            Console.WriteLine("{0} & {1} = {2}", b1, b2, b3);

            uint b4 = b1 | b2;
            Console.WriteLine("{0} | {1} = {2}", b1, b2, b4);


            b2 = 12584795u;
            uint b5 = b1 ^ b2;
            Console.WriteLine("{0} ^ {1} = {2}", b1, b2, b5);
            uint b6 = b5 ^ b2;
            Console.WriteLine("{0} ^ {1} = {2}", b5, b2, b6);


            uint b7;
            b7 = ~b1;
            Console.WriteLine("b7 = {0}", b7);
            string sb7 = Convert.ToString(b7, 2);
            Console.WriteLine("b7 = {0} --> {1}", b7, sb7.PadLeft(32, '0'));


            uint b8 = b1 << 3;
            string sb8 = Convert.ToString(b8, 2);
            Console.WriteLine("b8 = {0} --> {1}", b8, sb8.PadLeft(32, '0'));


            int n = 123445;
            n = n * 2;
            n = n << 1;

            uint b9 = 12345678u;
            string sb9 = Convert.ToString(b9, 2);
            Console.WriteLine("b09 = {0} --> {1}", b9, sb9.PadLeft(32, '0'));

            uint b10 = SetBit(b9, 4);
            string sb10 = Convert.ToString(b10, 2);
            Console.WriteLine("b10 = {0} --> {1}", b10, sb10.PadLeft(32, '0'));


            uint b11 = ResetBit(b10, 4);
            string sb11 = Convert.ToString(b11, 2);
            Console.WriteLine("b11 = {0} --> {1}", b11, sb11.PadLeft(32, '0'));

        }

        private static uint ResetBit(uint n, int k)
        {
            return n & (~(1u << k));
        }

        private static uint SetBit(uint n, int k)
        {
            return n | (1u << k);
        }
    }
}
