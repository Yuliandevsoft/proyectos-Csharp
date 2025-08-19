using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema 4:
//Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos: cargar el valor de
//su lado, imprimir su perímetro y su superficie.

namespace Proyecto62
{
    internal class Cuadrado
    {
        private int lado;

        public void Inicializar()
        {
            Console.WriteLine("Ingresa el valor del cuadrado: ");
            lado = int.Parse(Console.ReadLine());
            Perimetro();
            Area();
        }

        public void Perimetro()
        {
            Console.WriteLine("Su perimetro es: " + lado * 4);
        }

        public void Area()
        {
            Console.WriteLine("Su Área es: " + lado * lado);

        }
        
        static void Main(string[] args)
        {
            Cuadrado cuadradito = new Cuadrado();
            cuadradito.Inicializar();
            Console.ReadKey();
        }
    }
}

