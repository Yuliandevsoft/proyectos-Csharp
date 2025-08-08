using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Escribir un programa que płda ingresar la coordenada de un punto en el plano, es decir dos valores
            //enteros x e y (distintos a cero).
            //Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1° Cuadrante si x > 0 Y
            //y > 0, 2° Cuadrante: x < 0 Y y > 0, etc.)

            int x = 1, y = 1;

            Console.WriteLine("Ingrese el primer valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            y = int.Parse(Console.ReadLine());

            if(x > 0 && y > 0)
            {
                Console.WriteLine("Estas en el Cuadrante I");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Estas en el Cuadrante II");
                }else {

                        if (x < 0 && y < 0)
                        {
                            Console.WriteLine("Estas en el Cuadrante III");
                        }
                        else
                        {
                            if (x > 0 && y < 0)
                            {
                                Console.WriteLine("Estas en el Cuadrante IV");
                            }
                            else
                            {
                                Console.WriteLine("se encuentra en un eje");

                            }
                        }
                        Console.ReadKey();


                    }
                    
                }
            }


        }
    }

