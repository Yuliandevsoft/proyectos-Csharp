using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se ingresa por teclado un número positivo de uno o dos dígitos(1..99) mostrar un mensaje
            //indicando si el número tiene uno o dos dígitos.
            //(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)

            int numero;

            Console.Write("Ingrese el numero para saber si es de 1 digito o de 2 digitos: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 99)
            {
                Console.WriteLine("El numero " + numero + " es un numero de 2 digitos");

            }else if (numero <=9)
            {
                Console.WriteLine("El numero " + numero + " es un numero de 1 digito");
            }
            else
            {
                Console.WriteLine("Es un numero mayor a 2 digitos.");
                
            }
            Console.ReadKey();

        }
    }
}
