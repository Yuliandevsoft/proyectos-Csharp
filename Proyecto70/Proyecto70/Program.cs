using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema propuesto
//Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
//El valor acumulado de todos los elementos del vector.
//El valor acumulado de los elementos del vector que sean mayores a 36.
//Cantidad de valores mayores a 50.


namespace Proyecto70
{
    internal class SumatoriaElementos
    {
        private int[] valores;

        private void Elementos()
        {
            valores = new int[8];
            int sumaT = 0;

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Ingrese el valor {i + 1}: ");
                while(!int.TryParse( Console.ReadLine(),out valores[i]))
                {
                    Console.WriteLine("Entrada invalida, ingrese un numero valido: ");
                }
                //valores[i] = int.Parse(Console.ReadLine());
                sumaT += valores[i];

            }
            Console.WriteLine("\nEl valor acumulado de todos los elementos: " + sumaT);
            Mayores();


        }

        private void Mayores()
        {
            int mayores36 = 0;
            int mayores50 = 0;
            for (int i = 0; i < 8; i++)
            { 
                if (valores[i] > 36)
                {
                    mayores36 += valores[i];
                }

                if (valores[i] > 50) mayores50++;
            }

           
            
            Console.WriteLine("El valor acumulado de los elementos que sean mayores a 36: " + mayores36);
            Console.WriteLine("cantidad de elementos mayores a 50: " + mayores50);
        }

        static void Main(string[] args)
        {
            SumatoriaElementos El = new SumatoriaElementos();
            El.Elementos();
        }
    }
}
