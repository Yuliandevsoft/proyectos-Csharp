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

            int cantidad, lado1, lado2, lado3, equilatero = 0, isosceles = 0, escaleno = 0;


            Console.Write("Ingrese cuantos triangulos va a crear: ");
            Console.WriteLine("");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el primer lado del triangulo {i} : ");
                lado1 = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese el segundo lado del triangulo {i} : ");
                lado2 = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese el tercer lado del triangulo {i} : ");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado2 == lado3 )
                {
                    Console.WriteLine("Es equilátero");
                    equilatero++;
                }else
                {
                    if(lado1 != lado2 && lado2 != lado3)
                    {
                        Console.WriteLine("Es escaleno");
                        escaleno++;
                    }
                    else
                    {
                        Console.WriteLine("Es isósceles");
                        isosceles++;

                    }
                }

            }
            Console.WriteLine("---------------Cantidad de triángulos de cada tipo------------- \n ");
            Console.WriteLine("Triangulos de tipo Equilátero: " + equilatero);
            Console.WriteLine("Triangulos de tipo Isósceles: " + isosceles);
            Console.WriteLine("Triangulos de tipo Escaleno: " + escaleno);
            Console.WriteLine("--------------- Tipo de triángulo que posee menor cantidad------------- \n ");
            if (equilatero < isosceles && equilatero < escaleno)
            {
                Console.WriteLine(" Es el Equilátero");
            }
            else
            {
                if(equilatero > isosceles && isosceles < escaleno)
                {
                    Console.WriteLine(" Es el Isósceles");
                }
                else
                {
                    Console.WriteLine(" Es el Escaleno");
                }
            }
                Console.ReadKey();
        }
    }
}
