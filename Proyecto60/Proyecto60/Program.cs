using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema 2:
//Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos:
//inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero
//o no.
namespace Proyecto60
{
    internal class Triangulo
    {
        private int lado1, lado2, lado3;

        public void Inicializar()
        {
            Console.Write("Ingrese Medida 1 del triangulo: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Medida 2 del triangulo: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Medida 3 del triangulo: ");
            lado3 = int.Parse(Console.ReadLine());
        }

        public void ImprimirLadoMayor()
        {
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine("El lado mayor es: " + lado1);


            }else if(lado2 > lado1 && lado2 > lado3)
            {
                Console.WriteLine("El lado mayor es: " + lado2);
            }
            else
            {
                Console.WriteLine("El lado mayor es: " + lado3);
            }
        }

        public void Equilatero()
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es un triangulo Equilátero");
            }
            else
            {
                Console.WriteLine("No es Equilátero");
            }
        }
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Inicializar();
            triangulo.ImprimirLadoMayor();
            triangulo.Equilatero();
            Console.ReadKey();
        }
    }
}
