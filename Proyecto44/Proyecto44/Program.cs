using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la
            //medida de la base y la altura de un triángulo. El programa deberá informar:
            //a) De cada triángulo la medida de su base, su altura y su superficie.
            //b) La cantidad de triángulos cuya superficie es mayor a 12. 

            int n, baseT = 0, altura = 0, superficie = 0, cantidadT = 0 ;

            Console.Write("Ingrese que cantidad de triangulos desea calcular: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("");
                Console.Write($"Ingrese la base del triangulo {i}: ");
                baseT = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese la altura del triangulo {i}: ");
                altura = int.Parse(Console.ReadLine());

                superficie = (baseT * altura) / 2;

                if (superficie > 12) cantidadT++;

                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine($"La medida del triangulo {i} es: Base: {baseT}, su altura: {altura} y su superficie es de: {superficie}");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------");
            }
            Console.WriteLine("");
            Console.WriteLine($"La cantidad de triangulos cuya superficie es mayor a 12 es de: {cantidadT}");
            Console.ReadKey();


        }
    }
}
