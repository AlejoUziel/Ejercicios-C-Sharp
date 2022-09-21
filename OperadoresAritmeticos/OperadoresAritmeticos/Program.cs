using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* cree un programa que pida dos numeros y almacenelos en variables y realice las siguientes operaciones:
             suma, resta, multiplicacion y division y muestre el resultado en la consola. */

            Console.WriteLine("ingrese un numero");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            double num2= Convert.ToInt32( Console.ReadLine()); 

            double suma= num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine("la suma de los dos numeros es:"+ suma);
            Console.WriteLine("la resta de los dos numeros es:" + resta);
            Console.WriteLine("la multiplicacion de los dos numeros es:" + multiplicacion);
            Console.WriteLine("la division de los dos numeros es:" + division);
            Console.ReadKey();
        }
    }
}
