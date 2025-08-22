using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema propuesto
//Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
//elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer
//vector del mismo tamaño. Sumar componente a componente.

namespace Proyecto71
{
    internal class VectoresNumericos
    {
        private int[] valores1;
        private int[] valores2;
        private int[] valores3;

        public void CargaValores()
        {
            valores1 = new int[4];
            valores2 = new int[4];
            valores3 = new int[4];

            int suma1 = 0; 
            int suma2 = 0;
            Console.WriteLine("Ingresar los valores para calcular: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Del vector 1, ingrese el valor {i + 1} :");
                valores1[i] = int.Parse( Console.ReadLine());
                suma1 += valores1[i];

            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Del vector 2, ingrese el valor {i + 1} :");
                valores2[i] = int.Parse(Console.ReadLine());
                suma2 += valores2[i];

            }
            Console.WriteLine("");
            Operaciones();

        }
        public void Operaciones()
        {
            
            for(int i = 0;i < 4; i++)
            {
                valores3[i] = valores1[i] + valores2[i];
                Console.Write("Resultado: " + valores3[i]);
                Console.Write(" - ");
            }

        }
        static void Main(string[] args)
        {
            VectoresNumericos vectores = new VectoresNumericos();
            vectores.CargaValores();
            Console.ReadKey();
        }
    } 
}
