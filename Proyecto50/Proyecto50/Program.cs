using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //a) La cantidad de valores-ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15
            //d) El valor acumulado de los números ingresados que son pares.

            int valores, vNegativos = 0, vpositivos = 0, multi = 0, pares = 0 , sumaP = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Ingrese el valor {i} : ");
                valores = int.Parse(Console.ReadLine());

                if (valores > 0) vpositivos++;
                else vNegativos++;
                if (valores % 15 == 0) multi++;
                if (valores % 2 == 0) sumaP += valores; pares++;

            }
            Console.WriteLine("La cantidad de valores-ingresados negativos" + vNegativos);
            Console.WriteLine("La cantidad de valores ingresados positivos: " + vpositivos);
            Console.WriteLine("La cantidad de múltiplos de 15: " + multi);
            Console.WriteLine("La cantidad de los números ingresados que son pares: " + pares);
            Console.WriteLine("El valor acumulado de los números ingresados que son pares: " + sumaP);
            Console.ReadKey();
        }
    }
}
