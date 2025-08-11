using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe cuántos
            //tienen notas mayores o iguales a 7 y cuantos menores.

            int x = 1;
            int notasMayores = 0;
            int notasMenores = 0;
            int nota;

            while (x <= 10)
            {
                Console.Write("Ingrese la nota del alumno " + x + ": ");
                nota = int.Parse(Console.ReadLine());

                if (nota >= 7)
                {
                    notasMayores++;
                }
                else
                {
                    notasMenores++;
                }
                x++;
            }

            Console.WriteLine("Notas mayores o iguales a 7: " + notasMayores);
            Console.WriteLine("Notas menores a 7: " + notasMenores);
            Console.ReadKey();
        }
    }
}
