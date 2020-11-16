using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());

            int i = 1;
            int j = 1; // numer znaku w wierszu

            while (i<=n*n)
            {

                if (i % 2 == 0)
                {
                    Console.Write("O");
                }

                else
                {

                    Console.Write("X");
                }

                i++;

                j++;

                if (j > n)
                {
                    j = 1;
                    Console.WriteLine();
                }

                
            }

            Console.ReadKey();
        }
    }
}
