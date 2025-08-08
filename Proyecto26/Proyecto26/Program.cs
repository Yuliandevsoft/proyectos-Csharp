using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto

            //De un operario se conoce su sueldo y los años de antigüedad.Se pide confeccionar un programa que
            //lea los datos de entrada e informe:
            //a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento
            //del 20 %, mostrar el sueldo a pagar.
            //b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 anos, otorgarle un aumento de 5
            //%.
            //c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.

            int sueldo, antiguedad;
            double aumento = 0.20, resultado, aumento2 = 0.05, total;

            Console.WriteLine("Ingrese su sueldo en la empresa: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los años de antiguedad en la empresa: ");
            antiguedad = int.Parse(Console.ReadLine());

            if(sueldo < 500 && antiguedad >= 10)
            {
              resultado = sueldo * aumento;
                total = sueldo * aumento + sueldo;
                Console.WriteLine("Usted debe recibir un aumento de 20% y son: " + resultado + "USD, entonces ahora debe recibir un salario de: " + total + "USD");
            }
            else{
                if (sueldo < 500 && antiguedad < 10) {

                    resultado = sueldo * aumento2;
                    total = sueldo * aumento2 + sueldo;
                    Console.WriteLine("Usted debe recibir un aumento de 5% y son: " + resultado + "USD, entonces ahora debe recibir un salario de: " + total + "USD");
                }
                else
                {
                    Console.WriteLine("Usted todavia no recibe aumento, su sueldo se queda en: " + sueldo);
                }
                
            }
            Console.ReadKey();
        }
    }
}
