using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condiciones_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* cree un programa donde calcule si la nota del alumno es mayor a 70 pasa el año y si la nota esta entre 60 a 70 
               tiene derecho de ir a recuperacion y si es menor a 60 tiene que repetir el año */

            Console.WriteLine("ingrese la nota del alumno");
            double nota = Convert.ToDouble(Console.ReadLine()); 

        if(nota>70)
            {
                Console.WriteLine("el alumno pasa de año :)");
                Console.ReadKey();
            }
        else if(nota>60)
            {
                Console.WriteLine("el alumno tiene derecho a una recuperacion :) ");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("el alumno debe repetir el año :( ");
                Console.ReadKey();
            }



        }
    }
}
