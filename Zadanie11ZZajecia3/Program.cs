using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11ZZajecia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // i - numer wiersza
            {

                for (int j = n-1-i; j>=1  ; j--) // ilość spacji to jest dokładnie  n-1-i
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 1+i; k++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
