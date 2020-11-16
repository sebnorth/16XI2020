using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[5] { 5,4,3,2,1};
            Console.WriteLine(tablica[tablica.Length-1]);

            foreach (int item in tablica)
            {
                Console.Write("{0} ", item);
            }


            Console.ReadKey();
        }
    }
}
