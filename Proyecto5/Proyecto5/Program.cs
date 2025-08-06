using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;
            Console.Write("Digite el lado de un cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("El perimetro de un cuadrado es: ");
            Console.Write(perimetro);
            Console.ReadKey();


        }
    }
}
