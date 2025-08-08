using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condiciones compuestas con operadores
            //lógicos
            //Problema propuesto
            //Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en
            //pantalla la leyenda "Todos los números son menores a diez".

            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercero numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 <10 && num2 <10 && num3 <10) {
                Console.WriteLine("Todos los números son menores a diez");
            }
            else
            {
                Console.WriteLine("Todos los números son mayores a diez");
            }
            Console.ReadKey();
        }
    }
}
