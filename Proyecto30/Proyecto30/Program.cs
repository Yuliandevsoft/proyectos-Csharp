using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 3:
            //Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre
            //posteriormente la suma de los valores ingresados y su promedio.

            int x, valor, promedio, suma;
            x = 1;
            suma = 0;
           
            while (x <= 10) {

                Console.Write("Ingrese el valor del contador: ");
                valor = int.Parse(Console.ReadLine());
                suma = (suma + valor);
                x++;

            }
            promedio = suma / 10 ;
            Console.WriteLine("Esta es la suma de los valores ingresados: " + suma);
            Console.WriteLine("El promedio es: " +promedio);
            Console.ReadKey();

        }
        
    }
}
