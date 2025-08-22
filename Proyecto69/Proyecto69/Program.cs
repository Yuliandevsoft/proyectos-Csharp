using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Estructura de datos tipo vector
//Problema 3:
//Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y
//4 por la tarde)
//Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por
//turno
//Imprimir los gastos en sueldos de cada turno

namespace Proyecto69
{
    internal class ProgramaTurnosSueldo
    {
        private int[] turnoM;
        private int[] turnoT;

        public void CargarTurno()
        {
            turnoM = new int[4];
            turnoT = new int[4];

            Console.WriteLine("--- Calculdora de sueldos de empleados de la mañana y de la tarde ----");
            Console.WriteLine("");

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Los sueldos del empleado {i + 1} de la mañana: ");
                turnoM[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            for(int i = 0;i < 4; i++)
            {
                Console.Write($"Los sueldos del empleado {i + 1} de la tarde: ");
                turnoT[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            GastosEnSueldos();


        }

        private void GastosEnSueldos()
        {
            int sueldoM = 0;
            int sueldoT = 0;
            
            for(int i = 0; i < 4 ; i++)
            {
                sueldoM += turnoM[i];
                sueldoT += turnoT[i];

            }
            Console.WriteLine("Los gastos en sueldos del turno de la mañana son :" + sueldoM);
            Console.WriteLine("Los gastos en sueldos del turno de la tarde son :" + sueldoT);
        }
        static void Main(string[] args)
        {
            ProgramaTurnosSueldo turnosMT = new ProgramaTurnosSueldo();
            turnosMT.CargarTurno();
            Console.ReadKey();
        }
    }
}
