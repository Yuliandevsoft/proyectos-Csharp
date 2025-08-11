using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Mostraldlos múltiplos de 8 hasta el valor 500.Debe aparecer en pantalla 8 - 16 - 24, etc.

            int multiplo = 8;


            while (multiplo <= 500)
            {

                Console.Write(multiplo);
                Console.Write(" - ");
                multiplo = multiplo + 8;

            }

            Console.ReadKey();

        }
    }
}

