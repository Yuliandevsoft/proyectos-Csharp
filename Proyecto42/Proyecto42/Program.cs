using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 4:
            //Escribir un programa que lea 10 números enteros y luego muestre cuantos valores ingresados fueron
            //múltiplos de 3 y cuantos de 5.Debemos tener en cuenta que hay números que son múltiplos de 3 y
            //de 5 a la vez.


            int mult3 = 0, mult5 = 0, multAmbos = 0 ,valor ;

            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine($"ingrese el valor {i}: ");
                valor = int.Parse( Console.ReadLine() );

                if (valor%3 == 0) mult3++;
                if (valor%5 == 0) mult5++;
                if (valor%3 == 0 && valor %5 == 0) multAmbos++ ;

            }
            Console.WriteLine($"Los numeros multiplos de 3 son: {mult3} ");
            Console.WriteLine($"Los numeros multiplos de 5 son: {mult5} ");
            Console.WriteLine($"Los numeros multiplos de 3 y 5 a la vez son: {multAmbos} ");
            Console.ReadKey();


        }
    }
}
