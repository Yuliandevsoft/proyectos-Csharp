using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto58
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema 2:
            //Solicitar el ingreso de dos nombres de personas. Mostrar un mensaje si son iguales o distintos.

            string nombre, nombre2;
            Console.WriteLine("Ingrese el primer nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo nombre: ");
            nombre2 = Console.ReadLine();

            if (nombre != nombre2)
            {
                Console.WriteLine("Son nombres distintos");
            }
            else
            {
                Console.WriteLine("Sonn nombres iguales");
            }
            Console.ReadKey();
        }
    }
}
