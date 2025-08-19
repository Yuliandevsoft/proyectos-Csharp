using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema 3:
//Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los
//valores de x e y, imprimir en que cuadrante se encuentra dicho punto (concepto matemático, primer
//cuadrante si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.)
 
namespace Proyecto61
{
    internal class PlanoCartesiano
    {
        private int x, y;

        public void Inicializar()
        {
            do
            {
                Console.WriteLine("-----Ingrese los puntos del plano (999 para cerrar)-----");
                Console.WriteLine("");
                Console.Write("Ingrese el valor de X: ");
                x = int.Parse(Console.ReadLine());
                if (x != 999)
                {
                    Console.Write("Ingrese el valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    Cuadrantes();
                    Console.WriteLine("");

                }
           
            } while (x != 999);

        }

        public void Cuadrantes()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("--Se encuentra en el primer cuadrante");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("--Se encuentra en el segundo cuadrante");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.WriteLine("--Se encueentra en el tercer cuadrante");
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.WriteLine("--Se encuentra en el cuarto cuadrante");
                        }
                        else
                        {
                            Console.WriteLine("--Se encuentra en el origen del plano");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            PlanoCartesiano plano = new PlanoCartesiano();
            plano.Inicializar();
            //plano.Cuadrantes();
            Console.WriteLine("Presiona enter 2 veces para cerrar");
            Console.ReadKey();
            
        }
    }
}
