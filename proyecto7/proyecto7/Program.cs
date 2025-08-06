using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Estructura de programación secuencial
            //Problema propuesto
            //Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            float num1, num2, num3, num4, suma, promedio;
            //string linea;

            Console.Write("Digite el primer numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Digite el tercer numero: ");
            num3 = float.Parse(Console.ReadLine());
            Console.Write("Digite el cuarto numero: ");
            num4 = float.Parse(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;

            promedio = suma / 4;

            Console.Write("la suma es:");
            Console.WriteLine(suma);
            Console.Write("El promedio es: ");
            Console.WriteLine(promedio);
            Console.ReadKey();



        }
    }
}
