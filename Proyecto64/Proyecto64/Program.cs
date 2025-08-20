using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declaración de una clase y definición de
//objetos
//Problema Propuesto
//Implementar la clase operaciones. Se deben cargar dos valores enteros, calcular su
//suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados. |

namespace Proyecto64
{
    internal class Operaciones
    {
        private int valor, valor2;

        public void Inicializar()
        {
            Console.Write("Ingrese el primer valor: ");
            valor = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("------ Operaciones------");
            Suma();
            Resta();
            Multiplicacion();
            division();


        }

        public void Suma()
        {
           int suma = valor + valor2;
            Console.WriteLine("La suma de los valores es: " + suma );
        }

        public void Resta() 
        {
           int resta = valor - valor2;
            Console.WriteLine("La resta de los valores es: " + resta);
        
        }
        public void Multiplicacion()
        {
           int multiplicacion = valor * valor2;
            Console.WriteLine("El producto de los valores es: " + multiplicacion);
        }
        public void division()
        {
            int division = valor / valor2;
            Console.WriteLine("La division de los valores es: " + division);
        }


        static void Main(string[] args)
        {
            Operaciones operaciones1 = new Operaciones();
            operaciones1.Inicializar();
            Console.ReadKey();


        }
    }
}
