using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //    Se carga una fecha(día, mes y año) por teclado. Mostrar un mensaje si corresponde al primer
            //    trimestre del año(enero, febrero o marzo) Cargar por teclado el valor numérico del día, mes y año.
            //    Ejemplo: dia: 10 mes: 1 año: 2020.

            int dia, mes, year;

            Console.Write("Ingresa el dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el año: ");
            year = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 2)
            {
                Console.Write("Corresponde al primer trimestre del año (enero, febrero o marzo)");
            }
            else
            {
                if (mes == 2 || mes == 3)
                {
                    Console.Write("Corresponde al primer trimestre del año (enero, febrero o marzo)");
                }
                else
                {
                    Console.WriteLine("Dia: " + dia + " Mes: " +  mes + " Año: " + year);
                }
                Console.ReadKey();
            }
        }
    }
}
