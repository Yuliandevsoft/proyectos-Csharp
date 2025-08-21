using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

//Problema 2:
//Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
//Obtener el promedio de las mismas. Contar cuantas personas son más altas que el promedio y
//cuántas más bajas.

namespace Proyecto68
{
    internal class Personas
    {

        private float[] alturas;
        private float promedio, suma;
        private int altas = 0, bajas = 0;

        
        public void CargarAlturas()
        {
            alturas = new float[5];

            for (int i = 0; i < 5; i++) 
            {

            Console.Write("Cargar la altura:");
            alturas[i] = float.Parse(Console.ReadLine());

            }
            PromedioAltura();
            MayorMenor();



        }
        public void PromedioAltura()
        {
            for(int i = 0; i < 5; i++)
            {               
                suma += alturas[i];              
            }
            promedio = suma / 5;
            Console.WriteLine("El promedio de las alturas es: " + promedio);           
        }

        public void MayorMenor()
        {
            for(int i = 0;i < 5; i++)
            {
                if (alturas[i] > promedio)
                {
                    altas++;
                }
                else
                {
                    if (alturas[i] < promedio)
                    {
                        bajas++;
                    }
                }
            }
            Console.WriteLine("Contar cuantas personas son más altas que el promedio" + altas);
            Console.WriteLine("Contar cuantas personas son más bajas que el promedio" + bajas);
        }

        static void Main(string[] args)
        {
            Personas parray = new Personas();
            parray.CargarAlturas();
            Console.ReadKey();
        }
    }
}
