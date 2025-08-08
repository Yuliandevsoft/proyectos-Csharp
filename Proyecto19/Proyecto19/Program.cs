using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Confeccionar un programa que lea por teclado tres 
            //números distintos y nos muestre el mayor usando operador logico "&&"

            int num1, num2, num3;

            Console.Write("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercero numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Primer numero ingresado: "  + num1 + " es mayor al 2do y 3ro ingresado");
            }
            else
            {
                if(num2 > num3)
                {
                    Console.WriteLine("Segundo numero ingresado: " + num2 + " es mayor al 1ro y el 3ro ingresado");
                }
                else
                {
                    Console.WriteLine("Tercer numero ingresado: "  + num3 + " es mayor al 1ro y el 2do ingresado");
                }
            }

        }
    }
}
