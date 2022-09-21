using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condiciones_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Haga uso de la condicion if y else. Cree un programa que pida un numero y muestre si es par o impar 

            Console.WriteLine("ingrese un numero");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0) //Un número par es divisible por 2, es decir que al dividir el número por 2 el resto de la división es 0
            { 
                 Console.WriteLine("el numero es par!");
                Console.ReadKey();
            }
            else // la división entre un número impar y 2 siempre tendrá resto 1
            {
                Console.WriteLine("el numero es impar");
                Console.ReadKey();
            }
        }
    }
}
