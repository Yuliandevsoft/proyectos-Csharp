using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto

            //Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar
            //su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al
            //segundo.

            float num1, num2, suma, diferencia,producto,division;

            Console.Write("Ingresa el primer numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;

                Console.WriteLine("La suma de ambos numeros es: " + suma);
                Console.WriteLine("La diferencia de ambos numeros es: " + diferencia);

            }
            else
            {
                producto = num1 * num2;
                division = num1 / num2;

                Console.WriteLine("El producto del primer numero respecto al segundo numeros es: " + producto);
                Console.WriteLine("La división del primer numero respecto al segundo numeros es: " + division);

            }
            Console.ReadKey();
               
        }
    }
}
