using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar
            //un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados
            //cobran entre $100 y $300 y cuántos cobran más de $300.Además el programa deberá
            //informar el importe que gasta la empresa en sueldos al personal.

            int x = 1;
            int n, sueldo, suma = 0;
            int empleadoMa = 0;
            int empleadoMe = 0;

            Console.Write("Ingrese la cantidad de empleados: ");
            n = int.Parse(Console.ReadLine());

            while (x <= n) 
            {
                Console.Write($"Ingrese el sueldo {x}: ");
                sueldo = int.Parse(Console.ReadLine());

                if (sueldo >= 100 && sueldo <= 300)
                {
                    empleadoMe++;

                }
                else {

                    if(sueldo >300) empleadoMa++;

                }
                x++;
                suma += sueldo;
            }
            Console.WriteLine($"Cantidad de empleados que cobran entre $100 y $300: {empleadoMe}");
            Console.WriteLine($"Cantidad de empleados que cobran más de $300: {empleadoMa}");
            Console.WriteLine("Importe que gasta la empresa en sueldos al personal: " + suma);
            Console.ReadKey();



        }
    }
}
