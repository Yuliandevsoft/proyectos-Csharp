using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se ingresan un conjunto de n alturas de personas por teclado.Mostrar la altura promedio
            //de las personas.

            int x = 1;
            int n;
            float altura, promedio;
            float suma = 0;

            Console.Write("Ingrese la cantidad de personas: ");
            n = int.Parse(Console.ReadLine());

            while (x <= n)
            {
                Console.Write("Ingrese la altura" + x + ": ");
                altura= float.Parse(Console.ReadLine());
                suma = suma + altura;
                
                x++;
            }
            promedio = suma / n;
            Console.WriteLine("El promedio de las alturas ingresadas es este: " + promedio);
            Console.ReadKey();


        }
    }
}
