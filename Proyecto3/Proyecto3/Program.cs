﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int superficie;
            string linea;
            Console.Write("Ingrese el numero de lados: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            superficie = lado * lado;
            Console.Write("La superficie del cuadrado es: ");
            Console.Write(superficie);
            Console.ReadKey();
        }
    }
}
