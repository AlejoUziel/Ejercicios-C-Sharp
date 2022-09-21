using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDeTipoDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // convierta las siguientes variables 
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // conversion int a string
            Console.WriteLine(Convert.ToDouble(myInt));    // conversion int a double
            Console.WriteLine(Convert.ToInt32(myDouble));  // conversion double a int
            Console.WriteLine(Convert.ToString(myBool));   // conversion bool a string
            Console.ReadKey();  
        }
    }
}
