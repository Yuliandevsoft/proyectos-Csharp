using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras condicionales anidadas
            //Problema propuesto
            //Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y
            //muestre un mensaje indicando si tiene 1, 2, o 3 cifras.Mostrar un mensaje de error si el número de
            //cifras es mayor.
            int num;
            Console.WriteLine("Ingresa un numero entero positivo, si tiene 1, 2, o 3 cifras: ");
            num = int.Parse(Console.ReadLine());

            if(num < 10)
            {
                Console.WriteLine("Es un numero de 1 cifra");
            }
            else
            {
                if (num <= 99)
                {
                    Console.WriteLine("Es un numero de 2 cifras");
                }
                else {

                    if (num <= 999)
                    {
                        Console.WriteLine("Es un numero de 3 cifras");
                    }
                    else
                    {
                        Console.WriteLine("Error en la entrada de datos");
                    }
                }
            }
           
            
        }
    }
}
