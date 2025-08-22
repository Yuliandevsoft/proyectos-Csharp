using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema propuesto
//Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso Ay el curso
//B, cada curso cuenta con 5 alumnos.
//Realizar un programa que muestre el curso que obtuvo el mayor promedio general.

namespace Proyeco72
{
    internal class PrimerParcial
    {
        private float[] CursoA;
        private float[] CursoB;
        private float[] Suma;
        private float[] promedio;
        private void CargarNotas()
        {
            CursoA = new float[5];
            CursoB = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese la nota primer parcial {i + 1} :");
                CursoA[i] = float.Parse( Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese la nota primer parcial {i + 1} :");
                CursoB[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            PromedioGeneral();
        }

        public void PromedioGeneral()
        {
            Suma = new float[2];
            promedio = new float[2];

            for (int i = 0; i < 5; i++)
            {

                Suma[0] += CursoA[i];
                Suma[1] += CursoB[i];

            }
            promedio[0] = Suma[0] / 5;
            promedio[1] = Suma[1] / 5;

            if(promedio[0] > promedio[1])
            {
                Console.WriteLine("El promedio mayor general lo tiene el curso A");
            }
            else
            {
                Console.WriteLine("El promedio mayor general lo tiene el curso B");
            }
           
            Console.WriteLine("El total de promedio del curso A es:" + promedio[0]);
            Console.WriteLine("El total de promedio del curso B es:" + promedio[1]);
        }
        static void Main(string[] args)
        {
            PrimerParcial Notas = new PrimerParcial();
            Notas.CargarNotas();
            Console.ReadKey();

        }
    }
}
