using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema Propuesto
//Confeccionar una clase que represente un empleado. Definir como atributos su nombre y
//su sueldo. Confeccionar los métodos para la carga, otro para imprimir sus datos y por
//último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)

namespace Proyecto63
{
    internal class Empleado
    {
        private string nombre;
        private int sueldo;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            Impuestos();
        }

        public void Impuestos()
        {
            if (sueldo > 3000) Console.WriteLine("Debe pagar impuestos");
            else Console.WriteLine("No debe pagar impuestos");
        }
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Inicializar();
        }
    }
}
