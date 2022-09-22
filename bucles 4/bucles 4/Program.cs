using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // haga uso del ciclo foreach para leer los elementos de la matriz.
            string[] animales = { "iguana", "Vaca", "Conejo", "capibara" };
            foreach (string i in animales)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
