using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //suma es el acumulador, inicializado en 0 y luego al hacer la operacion suma = suma + valor; se iran acumulando los valores sumados, en ese 0.
            int suma = 0, promedio, valor;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ingrese el valor {i}: ");
                valor = int.Parse( Console.ReadLine() );
                suma = suma + valor;
            }
            promedio = suma / 10;
            Console.WriteLine($"La suma total de los datos ingresados es: {suma}");
            Console.WriteLine($"El promedio de los datos ingresados es: {promedio}");
            Console.ReadKey();

        }
    }
}
