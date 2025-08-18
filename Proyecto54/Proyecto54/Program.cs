using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 3:
            //Realizar un programa que permita ingresar el peso(en kilogramos) de piezas. El proceso termina
            //cuando ingresamos el valor 0.Se debe informar:
            //a) Cuántas piezas tienen un peso entre 9.8 Kg.y 10.2 Kg.? , cuántas con más de 10.2 Kg.? y cuántas
            //con menos de 9.8 Kg.?
            //b) La cantidad total de piezas procesadas.

            int suma, cant1 = 0, cant2 = 0, cant3 = 0;
            float peso;

            do
            {
                Console.Write("Ingrese el peso de la pieza (0 para finalizar): ");
                peso = float.Parse(Console.ReadLine());
                if(peso>=10.2)
                {
                    cant1++;
                }
                else
                {
                    if(peso > 9.8 && peso < 10.2)
                    {
                        cant2++;
                    }
                    else
                    {
                        if(peso > 0)
                        {
                            cant3++;
                        }
                    }
                }

            } while (peso != 0);
            Console.WriteLine("");
            suma = cant1 +  cant2 + cant3;
            Console.WriteLine("Cuántas piezas tienen un peso entre 9.8 Kg.y 10.2 Kg: " + cant2);
            Console.WriteLine("Cuántas piezas tienen un peso mayor a 10.2 Kg: " + cant1);
            Console.WriteLine("Cuántas piezas tienen un peso menor a 9.8 Kg: " + cant3);
            Console.WriteLine("Cantidad total de piezas procesadas: " + suma);

            Console.ReadKey();
        }
    }
}
