using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se cuenta con la siguiente información:
            //Las edades de 50 estudiantes del turno mañana.
            //Las edades de 60 estudiantes del turno tarde
            //Las edades de 110 estudiantes del turno noche.
            //Las edades de cada estudiante deben ingresarse por teclado.
            //a) Obtener el promedio de las edades de cada turno(tres promedios)
            //b) Imprimir dichos promedios(promedio de cada turno)
            //c) Mostrar por pantalla un mensaje que indique cual de los tres turnos tiene un promedio
            //de edades mayor.

            int edades, promedioM = 0, promedioN = 0, promedioT = 0;

            Console.WriteLine("------------ESTUDIANTES TURNO DE LA MAÑANA-------------------");
            for (int i = 1; i <= 5; i++)
            { 
                Console.Write($"Ingresa las edades de 5 estudiantes del turno mañana {i}: ");
                edades = int.Parse(Console.ReadLine());
                promedioM += edades;

            }
            Console.WriteLine("------------ESTUDIANTES TURNO DE LA TARDE-------------------");
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Ingresa las edades de 6 estudiantes del turno tarde {i}: ");
                edades = int.Parse(Console.ReadLine());
                promedioT += edades;

            }
            Console.WriteLine("------------ESTUDIANTES TURNO DE LA NOCHE-------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ingresa las edades de 10 estudiantes del turno noche {i}: ");
                edades = int.Parse(Console.ReadLine());
                promedioN += edades;

            }
            Console.WriteLine("");
            Console.WriteLine("Promedio de las edades del turno de la Mañana: " + promedioM / 5);
            Console.WriteLine("Promedio de las edades del turno de la Tarde: " + promedioT / 6);
            Console.WriteLine("Promedio de las edades del turno de la Noche: " + promedioN / 10);
            if (promedioM > promedioT && promedioM > promedioN) Console.WriteLine("Estudiantes del turno mañana tienen un promedio mayor");
            else if (promedioT > promedioN && promedioT > promedioM) Console.WriteLine("Estudiantes del turno tarde tienen un promedio mayor");
            else Console.WriteLine("Estudiantes del turno noche tienen un promedio mayor");
            Console.ReadKey();

        }
    }
}
