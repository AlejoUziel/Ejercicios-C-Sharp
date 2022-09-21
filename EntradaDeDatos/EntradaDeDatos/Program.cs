using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cree un programa que le pida al usuario su nombre y lo guarde en una variable y luego imprima el nombre.
            Console.WriteLine("cual es tu nombre?");
            string nombre = Console.ReadLine();  
            Console.WriteLine("hola! " + nombre);  
            Console.ReadKey();  
        }
    }
}
