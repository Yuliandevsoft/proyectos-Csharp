using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se
            //ingresan valores por teclado)

            int x = 1;
            int serie = 11;


            while (x <= 25)
            {
                Console.Write(serie);
                Console.Write(" - ");
                serie = serie +11;
                x++;
            }
           
            Console.ReadKey();

        }
    }
}
