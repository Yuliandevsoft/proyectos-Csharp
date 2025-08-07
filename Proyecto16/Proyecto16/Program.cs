using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se ingresa por teclado un valor entero, mostrar una leyenda que 
            //indique si el número es positivo o negativo y nulo si es 0 .

            int num;
            Console.Write("Ingrese un valor para mostrar una leyenda: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0) {
                Console.WriteLine("Es nulo");
            }
            else
            {
                if (num < 1)
                {
                    Console.WriteLine("Es negativo");
                }
                else
                {
                    Console.WriteLine("Positivo");
                }
            }


        }
    }
}
