using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema 1:
//Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de
//multiplicar de dicho valor. Finalizar el programa al ingresar el -1.

namespace Proyecto65
{
    internal class TablaMultiplicar
    {
        private int valor;
        public void CargarValor()
        {
            do
            {
                Console.WriteLine("Ingresa el valor a mostrar en tabla (-1 para finalizar programa): ");
                valor = int.Parse(Console.ReadLine());
                if (valor != -1)
                {
                    Calcular(valor);
                }

            } while (valor != -1);

        }
            public void Calcular(int v)
        {
            for (int n = 1; n <= 12; n++)
            {
                int resultado = v * n;
                Console.WriteLine(v + " x " + n + " = " + resultado);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TablaMultiplicar tablaMul1 = new TablaMultiplicar();
            tablaMul1.CargarValor();
            Console.WriteLine("Presiona enter dos veces para salir...");
            Console.ReadKey();
        }
    }
} 
