using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Escribir un programa que pida ingresar coordenadas(x, y) que representan puntos en el
            //plano.
            //Informar cuántos puntos se han ingresado en el primer, segundo, tercer y cuarto
            //cuadrante.Al comenzar el programa se pide que se ingrese la cantidad de puntos a
            //procesar.

            int x, y, valor, cuad1 = 0, cuad2 = 0, cuad3 = 0, cuad4 = 0;

            Console.WriteLine("Ingrese la cantidad de puntos en el plano a procesar: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                Console.Write("Ingresar coordenadas X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Ingresar coordenadas Y: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (x > 0 && y > 0) cuad1++;
                else
                {
                    if (x < 0 && y > 0) cuad2++;
                    else
                    {
                        if (x < 0 && y < 0) cuad3++;
                        else cuad4++;
                    }
                   
                }
            }
            Console.WriteLine("Puntos en primer cuadrante: " + cuad1);
            Console.WriteLine("Puntos en segundo cuadrante: " + cuad2);
            Console.WriteLine("Puntos en tercer cuadrante: " + cuad3);
            Console.WriteLine("Puntos en cuarto cuadrante: " + cuad4);
            Console.ReadKey();
        }
    }

}
