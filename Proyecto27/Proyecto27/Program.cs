using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto con if anidados (sale mejor hacerlo con if else).
            //Escribir un programa en el cual: dada una lista de tres valores numéricos distintos se calcule e
            //informe su rango de variación(debe mostrar el menor y el mayor de ellos).

            int n1, n2, n3;

            Console.Write("Ingrese el primer valor numérico: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor numérico: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer valor numérico: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("El primer valor numérico es el mas pequeño: " + n1);
            }
            else
            {
                if (n2 < n3)
                {
                    Console.WriteLine("El segundo valor numérico es el mas pequeño: " + n2);
                }
                else
                {
                    Console.WriteLine("El tercer valor numérico es el mas pequeño: " + n3);
                }
            }

                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("El primer valor numérico es el mas grande: " + n1);
                }
                else
                {
                    if (n2 > n3)
                    {
                        Console.WriteLine("El segundo valor numérico es el mas grande: " + n2);
                    }
                    else
                    {
                        Console.WriteLine("El tercer valor numérico es el mas grande: " + n3);
                    }
                }
                Console.ReadKey();

            }
        }
    }

