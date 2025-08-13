using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Desarrollar un programa que muestre la tabla de multiplicar del 5(del 5 al 50) 

            int tabla = 5, operacion;

            Console.WriteLine("Tabla de multiplicar del 5: ");
            Console.WriteLine("");

            for (int i = 1; i <= 50; i++)
            {
                operacion = tabla * i;
                Console.WriteLine($"5 x {i} = " + operacion);
            }
            Console.ReadKey();
            
        }
    }
}
