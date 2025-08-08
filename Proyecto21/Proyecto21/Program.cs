using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condiciones compuestas con operadores lógicos
            //Problema propuesto
            //Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha
            //corresponde a Navidad.

            int dia, mes, year;

            Console.Write("Ingrese el dia: ");
            dia =  int.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el año: ");
            year = int.Parse(Console.ReadLine());

            if (dia == 25 && mes == 12) {

                Console.WriteLine("Dia: " + dia + " Mes: " + mes + " Año: " + year);
                Console.WriteLine("Ya hoy es navidad!!!");
            }
            else
            {
                Console.WriteLine("Dia: "+ dia + " Mes: "+ mes + " Año: "+ year);
                Console.WriteLine("Aun no es navidad");
            }
            Console.ReadKey();

        }
    }
}
