using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condiciones_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*cree un programa que pida un numero del 1 al 7 y que segun el numero del 1 al 7 muestre el dia de la semana que es,
              por ejemplo si el numero ingresado es el 2  que imprima en pantalla martes. */

            Console.WriteLine("ingrese un numero del 1 al 7");
            int dia = Convert.ToInt32(Console.ReadLine());

            switch(dia)
            {
                case 1:
                    {
                        Console.WriteLine("lunes");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("martes");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("miercoles");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("jueves");
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("viernes");
                        Console.ReadKey();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("sabado");
                        Console.ReadKey();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("domingo");
                        Console.ReadKey();
                        break;
                    }

                default:
                    Console.WriteLine("el numero debe ser entre el 1 al 7, no hay coincidencia.");
                    Console.ReadKey();
                    break;
                    
            }
        }
    }
}
