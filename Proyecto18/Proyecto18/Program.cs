using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras condicionales anidadas
            //Problema propuesto
            //Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información:
            //cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó
            //correctamente.Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el
            //nivel del mismo según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
            //            Nivel máximo: Porcentaje >= 90 %.
            //Nivel medio: Porcentaje >= 75 % y < 90 %.
            //Nivel regular: Porcentaje >= 50 % y < 75 %.
            //Fuera de nivel: Porcentaje < 50 %.

            int totalp, totalco, porcentaje;

            Console.Write("Digite la cantidad de preguntas: ");
            totalp = int.Parse(Console.ReadLine());
            Console.Write("Digite el total  de preguntas correctas: ");
            totalco = int.Parse(Console.ReadLine());

            porcentaje = (totalco * 100 / totalp);

            if (porcentaje >= 90)
            {
                Console.WriteLine("Nivel máximo");
            }
            else
            {
                if (porcentaje >= 75)
                {
                    Console.WriteLine("Nivel Medio");
                }
                else
                {
                    if (porcentaje >= 50)
                    {
                        Console.WriteLine("Nivel regular");
                    }
                    else
                    {
                        Console.WriteLine("Fuera de Nivel");
                    }
                    Console.ReadKey();
                }
            }





        }
    }
}
