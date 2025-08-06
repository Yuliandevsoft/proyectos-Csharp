using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, producto;
            string linea;
            Console.Write("Digite primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Digite segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Digite tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Digite cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);
            suma = num1 + num2;
            producto = num2 * num3;
            Console.Write("La suma de los dos primeros numeros es: ");
            Console.WriteLine(suma);
            Console.Write("El producto del tercer y el cuarto numero es: ");
            Console.Write(producto);
            Console.ReadKey();








        }
    }
}
