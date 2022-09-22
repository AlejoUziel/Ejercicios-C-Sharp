using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Haga uso del ciclo Do 
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 100);
            Console.ReadKey();
        }
    }
}
