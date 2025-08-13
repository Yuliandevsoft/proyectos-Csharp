using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los
            //últimos 5 valores ingresados.

            int valor, suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ingrese el valor {i} : ");
                valor = int.Parse( Console.ReadLine());

                if (i > 5 ) suma += valor; // es lo mismo que suma = suma + valor y tener en cuenta que no es =+ sino += 
                    
            }
            Console.WriteLine($"La suma de los ultimos 5 valores ingresados es de: {suma} ");

        }
    }
}
