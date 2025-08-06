using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura de programación secuencial
            //Problema propuesto:
            //Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva
            //el cliente.Mostrar lo que debe abonar el comprador.

            double precio, abonar;
            int cantidad;

            Console.Write("Ingrese el precio del articulo a comprar: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad  del articulo a comprar: ");
            cantidad = int.Parse(Console.ReadLine());

            abonar = precio * cantidad;

            Console.Write("El comprador debe pagar: ");
            Console.WriteLine(abonar);
            Console.ReadKey();


        }
    }
}
