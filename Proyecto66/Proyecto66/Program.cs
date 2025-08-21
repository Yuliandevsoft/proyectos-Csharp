using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Métodos que retornan un tipo de dato.
//Un método puede retornar un dato:
//public [tipo de dato][nombre del método] ([parámetros])
//[algoritmo]
//return [tipo de dato]
//}
//Cuando un metodo retorna un dato en vez de indicar la palabra clave void previo al nombre del
//método indicamos el tipo de dato que retorna. Luego dentro del algoritmo en el momento que
//queremos que finalice el mismo y retorne el dato empleamos la palabra clave return con el valor
//respectivo.
//Problema 2:
//Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el
//menor

namespace Proyecto66
{
    internal class MayorMenor
    {
        public void CargarValores()
        {
            int valor1, valor2, valor3;
            Console.Write("Ingrese el primer valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer valor: ");
            valor3 = int.Parse(Console.ReadLine());

            int Mayor = CalcularMayor(valor1, valor2, valor3);
            Console.WriteLine("El mayor de los 3 valores es: " +  Mayor);
            int Menor = CalcularMenor(valor1, valor2, valor3);
            Console.WriteLine("El menor de los 3 valores es: " + Menor);
        }

        public int CalcularMayor(int v1, int v2, int v3)
        {
            if (v1 > v2 && v1 > v3)
            {
                return v1;
            }
            else
            {
                if (v2 > v3)
                {
                    return v2;
                }
                else
                {
                    return v3;
                }
            }
        }

        public int CalcularMenor(int v1, int v2, int v3)
        {
            if (v1 < v2 && v1 < v3)
            {
                return v1;
            }
            else
            {
                if (v2 < v3)
                {
                    return v2;
                }
                else
                {
                    return v3;
                }
            }
        }

        static void Main(string[] args)
        {
            MayorMenor mayorme1 = new MayorMenor();
            mayorme1.CargarValores();
            Console.WriteLine("Presione dos veces la tecla ENTER para cerrar...");
            Console.ReadKey();
        }
    }
}
