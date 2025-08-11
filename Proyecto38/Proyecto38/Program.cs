using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Desarrollar un programa que permita cargar n números enteros y luego nos informe
            //cuantos valores fueron pares y cuantos impares.
            //Emplear el operador "%" en la condición de la estructura condicional:
            // if (valor % 2 == 0)//Si el if da verdadero luego es par.

            int n = 1, valor, valor2, par = 0 , impar=0 ;

            Console.WriteLine($"Ingrese la cantidad de numeros enteros: ");
            valor = int.Parse( Console.ReadLine());

            while(n <= valor)
            {
                Console.WriteLine($"Ingresa el numero {n}: ");
                valor2 = int.Parse(Console.ReadLine());
                if (valor2 % 2 == 0) par++;
                else impar++;
                n++;


            }
            Console.WriteLine($"Son par {par}");
            Console.WriteLine($"Son impar {impar}");

            Console.ReadKey();
        }
       
    }
}
