using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BaseConverter
{
    class Program
    {
        static char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        static void Main(string[] args)
        {
            //int n = 42;  // numarul pe care il convertim 
            int b1 = 10; // baza sursa
            int b2 = 2;  // baza tintal
            // int n = 47, b1 = 10, b2 = 2;
            //ConvertFrom10(n, b2);


            string line;
            Console.WriteLine("Introduceti baza sursa: ");
            line = Console.ReadLine();

            b1 = int.Parse(line);
            string numar;
            do
            {
                Console.WriteLine("Introduceti numarul in baza {0}", b1);
                
                numar = Console.ReadLine();
                bool b = ValidareNumar(numar, b1);
                if (b)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Numarul nu este valid. Try again!!");
                }
            } while (true);
            Console.WriteLine("Introduceti baza tinta");
            b2 = int.Parse(Console.ReadLine());

            int nb10 = ConvertTo10(numar, b1);
            Console.WriteLine("Numarul in baza 10 este: {0}", nb10);
            //BigInteger big = new BigInteger(12345678);
            //Console.WriteLine(BigInteger.Pow(big, 5));
        }

        private static int ConvertTo10(string numar, int b1)
        {
            int valoare = 0;
            for (int i = 0; i < numar.Length; i++)
            {
                int j = 0;
                while (numar[i] != digits[j])
                {
                    j++;
                }
                valoare = valoare * b1 + j;
            }
            return valoare;
        }

        private static bool ValidareNumar(string numar, int b1)
        {
            
            bool gasit;
            for (int i = 0; i < numar.Length; i++)
            {
                gasit = false;
                for (int j = 0; j < b1; j++)
                {
                    if (numar[i] == digits[j])
                    {
                        gasit = true;
                        break;
                    }
                }
                if (!gasit)
                    return false;
            }

            return true;
        }

        private static void ConvertFrom10(int n, int b2)
        {
            while (n != 0)
            {
                Console.WriteLine(n % b2);
                n = n / 2;
            }
        }

       
    }
}
