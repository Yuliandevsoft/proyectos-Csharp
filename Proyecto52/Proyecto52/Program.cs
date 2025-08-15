using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            do
            {
                Console.Write("Ingrese un valor entre 0 y 999 (0 para finalizar programa): ");
                valor = int.Parse(Console.ReadLine());
                    if( valor != 0)
                    {   
                    
                      if(valor >= 100 && valor <= 999)
                        {
                            Console.WriteLine("Tiene 3 digitos"); 
                        } else
                            {
                            if (valor >= 10)
                            {
                                Console.WriteLine("Tiene 2 digitos");
                            }
                            else
                            {
                                Console.WriteLine("Tiene 1 digito");
                            }      
                        }

                      }

            } while(valor != 0);
        }
    }
}
