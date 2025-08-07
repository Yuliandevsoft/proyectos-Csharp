using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, promedio;

            Console.Write("Ingrese la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

             if(promedio >= 7)
            {
                Console.WriteLine("Promocionado");

            }
            else
            {
                if (promedio >= 4)
                {
                    Console.WriteLine("Regular");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            Console.ReadKey();
                    



        }
    }
}
