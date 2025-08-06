using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se ingresan tres notas de un alumno, si el promedio es mayor o igual a 
            //siete mostrar un mensaje "Promocionado".

            float nota1, nota2, nota3,suma, promedio;
            Console.Write("Ingresa la primera nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Ingresa la segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Ingresa la tercera nota: ");
            nota3 = float.Parse(Console.ReadLine());

            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado, tienes un promedio de " + promedio);
            }
            else
            {
                Console.WriteLine("No promocionado, tienes un promedio de " + promedio );
            }
            Console.ReadKey();
        }
    }
}
