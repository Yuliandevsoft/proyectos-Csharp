using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHoras;
            float sueldo;
            string linea;
            Console.Write("Ingrese Horas trabajadas por el operario: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            Console.Write("Ingrese el pago por hora:");
            linea = Console.ReadLine();
            costoHoras = float.Parse(linea);
            sueldo = horasTrabajadas * costoHoras;
            Console.Write("El sueldo total del operario es:");
            Console.Write(sueldo);
            Console.ReadKey();

        }
    }
}
