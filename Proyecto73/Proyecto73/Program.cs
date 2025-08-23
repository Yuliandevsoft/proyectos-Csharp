using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema propuesto
//Cargar un vector de 10 elementos y verificar posteriormente si el mismo esta ordenado de
//menor a mayor.

namespace Proyecto73
{
    internal class ElementosMeMa
    {
        private int[] elemento;
        private int[] menores;

        private void CargarElementos()
        {
            elemento = new int[10];
            menores = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Ingresa el valor {i + 1}: ");
                while(!int.TryParse(Console.ReadLine(), out elemento[i]))
                {
                    Console.WriteLine("Valor invalido, Ingrese un valor numerico valido: ");
                }
            }
            for(int i = 0;i < 10; i++)
            {
                if (elemento[i] < menores[+i])
                {
                    Console.WriteLine(elemento[i]);
                }
            }
           
            
            

        }
        static void Main(string[] args)
        {
            ElementosMeMa elemema = new ElementosMeMa();
            elemema.CargarElementos();

            Console.ReadKey();
        }
    }
}
