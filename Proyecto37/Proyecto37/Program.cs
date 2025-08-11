using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto37
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Realizar un programa que permita cargar dos listas de 15 valores cada una.
            //Informar con un mensaje cual de las dos listas tiene un valor acumulado mayor
            //(mensajes "Lista 1 mayor", "Lista 2 mayor", "Listas iguales")
            //Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo.

            int valor;
            int x = 1;
            int lista1 = 0, lista2 = 0;

            Console.WriteLine("------Primera Lista------");

            while (x <= 15) 
            {
                Console.Write($"Ingrese el primer valor {x} : ");
                valor = int.Parse( Console.ReadLine() );
                lista1 = lista1 + valor;
              
                x++;
            }
            Console.WriteLine("------Segunda Lista------");
            x = 1;
            while (x <= 15) 
            {
                Console.Write($"Ingrese el primer valor {x} : ");
                valor = int.Parse(Console.ReadLine());
                lista2 = lista2 + valor;
               
                x++;
            }

            Console.WriteLine($"La primera lista tiene {lista1} valores.");

            Console.WriteLine($"La segunda lista tiene {lista2} valores.");

            if (lista1 > lista2)
            {
                Console.WriteLine("La lista 1 es mayor");
            }
            else 
            {
                if(lista2 > lista1)
                {
                    Console.WriteLine("La lista 2 es mayor");
                }
                else 
                {
                    Console.WriteLine("Las listas son iguales");
                }
            }

            Console.ReadKey();
        }
    }
}
