using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema 1:
//Se desea guardar los sueldos de 5 operarios.
//Según lo conocido deberíamos definir 5 variables si queremos tener en un cierto momento los 5
//sueldos almacenados en memoria.
//Empleando un vector solo se requiere definir un único nombre y accedemos a cada elemento por
//medio del subíndice.

namespace Proyecto67
{
    internal class SueldoOperarios
    {
        private int[] sueldo;

        public void CargarOperarios()
        {
            sueldo = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el sueldo {i + 1 } : ");
                sueldo[i] = int.Parse(Console.ReadLine());
               
            }
            Mostrar();
        }
         
        public void Mostrar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Los sueldos son" + sueldo[i]);
            }
        }
        static void Main(string[] args)
        {
            SueldoOperarios sueldo1 = new SueldoOperarios();
            sueldo1.CargarOperarios();
            Console.ReadKey();

        }
    }
}
