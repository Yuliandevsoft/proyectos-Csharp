using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 4:
            //Una planta que fabrica perfiles de hierro posee un lote de n piezas.
            //Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego
            //ingrese la longitud de cada perfil; sabiendo que la pieza cuya longitud esté comprendida en el rango
            //de 1,20 y 1,30 son aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote.


            int x, cantidad, n ;
            float largo;
            x = 1;
            cantidad = 0;

            Console.Write("Cuantas piezas procesara: ");
            n = int.Parse(Console.ReadLine());

            while (x <= n ) 
            { 
                Console.Write("Ingrese la medida de la pieza: ");
                largo = float.Parse(Console.ReadLine());

                if (largo >= 1.20 && largo <= 1.30) 
                { 
                    cantidad = cantidad + 1;
                                    
                }
                x++;
            }
            Console.WriteLine("Cantidad de piezas aptas: " + cantidad);
            Console.ReadKey();

        }
    }
}
