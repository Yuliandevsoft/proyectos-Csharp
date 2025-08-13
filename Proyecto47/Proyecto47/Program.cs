using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla
            //de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.

            Console.Write("Ingrese cual tabla del 1 al 10 quiere ver: \n ");
            int n = int.Parse(Console.ReadLine());
            tablaMultiplicacion(n);

            Console.ReadKey();
        }
        

        private static void tablaMultiplicacion(int n)
        {
            if (n > 10)
            {
                Console.WriteLine("Error!");
                Console.Write("Debe ingresar una tabla del 1 al 10: ");
                tablaMultiplicacion(int.Parse(Console.ReadLine()));
                return;

            }

            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine($"\n {n} x {i} = {n * i}");
            }
                Console.ReadKey();
                Console.Clear();
                Console.Write("Debe ingresar una tabla del 1 al 10: ");
                tablaMultiplicacion(int.Parse(Console.ReadLine()));


        }



    }

}
