using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.

            int num1, num2 ,num3;

            Console.Write("Ingresa el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if(num1 > num3){

                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            Console.ReadKey();


        }
    }
}
