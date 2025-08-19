using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto59
{
    internal class Persona
    {
        private string nombre;
        private int edad;

        public void Inicializar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());

        }

        public void Impirmir()
        {
            Console.WriteLine("--------------- Datos de la persona ---------------");
            Console.WriteLine("");
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine(nombre + " es mayor de edad");
            }
            else
            {
                Console.WriteLine(nombre + " no es mayor de edad");
            }
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Inicializar();
            persona1.Impirmir();
            persona1.EsMayorEdad();
            Console.ReadKey();
        }
    }
}  
 