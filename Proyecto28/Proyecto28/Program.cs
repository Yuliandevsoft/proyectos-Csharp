using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 1:
            //Realizar un programa que imprima en pantalla los números del 1 al 100.

            int x = 2;

            while (x <= 100) 
            {
                Console.Write(x);
                Console.Write(" - ");
                // x = x + 1;
                //otra forma x++
                x = x + 2;
            }
            Console.ReadKey();

            //Probemos algunas modificaciones de este programa y veamos que cambios se deberían hacer para:
            //1 - Imprimir los números del 1 al 500.
            //2 - Imprimir los números del 50 al 100.
            //3 - Imprimir los números del - 50 al 0.
            //4 - Imprimir los números del 2 al 100 pero de 2 en 2(2, 4, 6, 8....100).
            //Respuestas:
            //1 - Debemos cambiar la condición del while con x <= 500.
            //- Debemos inicializar x con el valor 50.
            //- Inicializar x con el valor -50 y fijar la condición x <= 0.
            //- Inicializar a x con el valor 2 y dentro del bloque repetitivo incrementar a
            //x en 2
            //(x = x + 2)
        }
    }
}
