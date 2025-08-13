using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto47_version2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Problema propuesto
        //Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla
        //de multiplicar del mismo(los primeros 13 términos)
        //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.

        Tabla:
            int n;
            do
            {
                Console.WriteLine("Error!");
                Console.Write("Ingrese cual tabla del 1 al 10 quiere ver: \n ");
                n = int.Parse(Console.ReadLine());
            }
            while (n > 10);

            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine($"\n {n} x {i} = {n * i}");
            }

            Console.ReadKey();
            Console.Clear();
            goto Tabla;
        }



    }

}
