using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    internal class Program
    {
        static void MiPrimerMetodo()  // metodo 
        {
            Console.WriteLine("Este mensaje esta dentro de un metodo!"); 
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
           MiPrimerMetodo(); // llamada del metodo.
        }
    }
}
