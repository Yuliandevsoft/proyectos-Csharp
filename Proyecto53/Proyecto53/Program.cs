using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 2:
            //Escribir un programa que solicite la carga de números por teclado, obtener su promedio.Finalizar la
            //carga de valores cuando se cargue el valor 0.
            //Cuando la finalización depende de algún valor ingresado por el operador conviene el empleo de la
            //estructura do while, por lo menos se cargará un valor(en el caso más extremo se carga 0, que indica
            //la finalización de la carga de valores)

            int valor, suma = 0, cant = 0, promedio;

            do
            {
                Console.Write("Ingrese un valor(0 para finalizar)");
                valor = int.Parse(Console.ReadLine());
                if(valor != 0)
                {
                    suma += valor;
                    cant++;
                }


            } while (valor != 0);

            if(cant != 0)
            {
                promedio = suma / cant;
                Console.WriteLine("El promedio de los valores ingresados: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron valores");
            }
            Console.ReadKey();


        }
    }
}
