using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {

        static int PodwojElement(int[] tab, int indeks) {

            return 2 * tab[indeks];
        }
        
        static int PodwojPierwszyElement(int[] array) {

            return 2 * array[0];
        }
        
        static void Main(string[] args)
        {
            int[] tablica = { -1, -10, -100, -1000 };
            // Console.WriteLine(PodwojPierwszyElement(tablica));
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("{0} ", PodwojElement(tablica, i ));
            }

            Console.ReadKey();
        }
    }
}
