using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // haga uso del bucle WHILE, Imprima en consola los numeros del 1 al 100.

            int Numero = 0;
            while(Numero <= 100)
            {
                Console.WriteLine(Numero);
                Numero++;
            }
            Console.ReadKey();
        }
    }
}