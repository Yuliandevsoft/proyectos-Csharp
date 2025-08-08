using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condiciones compuestas con operadores lógicos

            //Problema propuesto
            //Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10,
            //imprimir en pantalla la leyenda "Alguno de los números es menor a diez".|

            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercero numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.WriteLine("Alguno de los números es Menor a diez");
            }
            else
            {
                Console.WriteLine("Todos son mayores a diez");
            }
            Console.ReadKey();
        }
    }
}
