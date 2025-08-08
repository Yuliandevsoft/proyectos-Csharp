using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condiciones compuestas con operadores lógicos

            //Problema propuesto
            
            //Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el
            //segundo y a este resultado se lo multiplica por el tercero

            int num1, num2, num3, resultado;

            Console.Write("Ingrese primer valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese tercer valor: ");
            num3 = int.Parse(Console.ReadLine());

            resultado = (num1 + num2) * num3;

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("La suma de los dos primeros valores: " + (num1 + num2) + " y su multiplicacion por el 3ro: " + num3 + " es igual a: " + resultado);
            }
            else
            {
                Console.WriteLine("Los 3 valores son diferentes no se reealiza la operación");
            }
            Console.ReadKey();

        }
    }
}
