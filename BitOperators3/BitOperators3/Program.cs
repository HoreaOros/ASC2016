using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperators3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 0xFFu;

            Console.WriteLine("n = {0:X}", n);

            

            Console.WriteLine("n = {0}", Base2(n));

            n = SetBit(n, 10);
            Console.WriteLine("n = {0}", Base2(n));

            n = ResetBit(n, 10);
            Console.WriteLine("n = {0}", Base2(n));


            int k = 10;
            string mesaj = "";
            if (!IsSet(n, k))
                mesaj = "nu ";

            Console.WriteLine("Bitul de pe pozitia {0} {1}este setat", k, mesaj);


            n = 0xFFFF;
            Console.WriteLine("n = {0} --> {1}", n, Base2(n));


            uint key = 1548751u;

            uint c = n ^ key;
            Console.WriteLine("c = {0} --> {1}", c, Base2(c));

            uint d = c ^ key;

            if (d == n)
            {
                Console.WriteLine("Decryption successfull");
                Console.WriteLine("d = {0} --> {1}", d, Base2(d));
            }
            else
            {
                Console.WriteLine("Decryption failed");
            }
        }

        private static bool IsSet(uint n, int k)
        {
            return ((n >> k) & 1u) == 1u;
        }

        private static uint ResetBit(uint n, int k)
        {
            uint mask = ~(1u << k);
            return n & mask;
        }

        private static string Base2(uint n)
        {
            string b1 = Convert.ToString(n, 2);
            return b1.PadLeft(32, '0');
        }

        private static uint SetBit(uint n, int k)
        {
            uint mask = 1u << k;

            return n | mask;
        }
    }
}
