using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Realizar un programa que acumule(sume) valores ingresados por teclado hasta ingresar
            //el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el valor
            //acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int suma = 0, valor, nulo = 0, menor = 0, mayor = 0;
            do
            {
                Console.Write("Ingrese valores (9999 para finalizar): ");
                valor = int.Parse(Console.ReadLine());
               // if (valor == 9999) break;

                if (valor != 9999)
                {
                    if (valor > 0) mayor++;
                    if (valor < 0) menor++;
                    if (valor == 0) nulo++;
                    suma += valor;

                }
                else
                {
                    Console.WriteLine("Ha finalizado la carga");
                }
               

            } while (valor != 9999);
         
                if (suma == 0)
                {
                    Console.WriteLine("La cantidad total de valores ingresados es nula");
                }
                else
                {
                    if (suma < 0)
                    {
                        Console.WriteLine("La cantidad total de valores ingresados es negativa");
                    }
                    else
                    {
                        Console.WriteLine("La cantidad total de valores ingresados es mayor a cero");
                    }
                

                Console.WriteLine("");
                Console.WriteLine("Cantidad de valores mayores a cero son: " + mayor);
                Console.WriteLine("Cantidad de valores negativos son: " + menor);
                Console.WriteLine("Cantidad de valores iguales a cero son: " + nulo);
                Console.ReadKey();


            }
        }
    }
}
