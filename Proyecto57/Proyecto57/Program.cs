using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 1:
            //Solicitar el ingreso del nombre y edad de dos personas. Mostrar el nombre de la persona con mayor edad.
            string nombre1, nombre2;
            int edad, edad2;

            Console.WriteLine("ingrese el primer nombre: ");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo nombre: ");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona: ");
            edad2 = int.Parse(Console.ReadLine());

            if (edad > edad2)
            {
                Console.WriteLine("La persona con Mayor edad es: " + nombre1);
            }
            else
            {
                Console.WriteLine("La persona con Mayor edad es: " + nombre2);
            }
            Console.ReadKey();


        }
    }
}
