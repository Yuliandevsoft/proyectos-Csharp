using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Realizar un programa que lea los lados de n triángulos, e informar:
            //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales), isósceles
            //(dos lados iguales), o escaleno(ningún lado igual)
            //b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.

            int cantidad, lado, equilatero = 0, isosceles = 0, escaleno = 0;


            Console.Write("Ingrese cuantos triangulos va a crear: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i < cantidad; i++)
            {
                Console.Write($"Ingrese el primer lado del triangulo {i} : ");
                lado = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese el segundo lado del triangulo {i} : ");
                lado = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese el tercer lado del triangulo {i} : ");
                lado = int.Parse(Console.ReadLine());

                if (lado == lado && lado == lado) Console.WriteLine("de tipo Equilátero"); equilatero++;
                if (lado == lado && lado != lado) Console.WriteLine("de tipo Isósceles"); isosceles++; 
                else Console.WriteLine("de tipo  Escaleno"); escaleno++;



            }
            Console.WriteLine("---------------Cantidad de triángulos de cada tipo------------- \n ");
            Console.WriteLine("Triangulo es de tipo Equilátero: " + equilatero);
            Console.WriteLine("Triangulo es de tipo Isósceles: " + isosceles);
            Console.WriteLine("Triangulo es de tipo Escaleno: " + escaleno);
            Console.ReadKey();



        }
    }
}
