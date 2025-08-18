using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto:

            //En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada cuenta
            //corriente se conoce: numero de cuenta y saldo actual. El ingreso de datos debe finalizar al
            //ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe
            //a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            //Estado de la cuenta:
            //'Acreedor' si el saldo es > 0.
            //'Deudor' si el saldo es<0.
            //'Nulo' si el saldo es = 0.
            //b) La suma total de los saldos acreedores.

            int saldo, numCuenta, suma = 0;

            do
            {
                Console.WriteLine("");  
                Console.Write("Ingrese numero de cuenta: ");
                numCuenta = int.Parse(Console.ReadLine());

                if (numCuenta < 0) break;

                Console.Write("Ingrese saldo actual: ");
                saldo = int.Parse(Console.ReadLine());
               
               if (saldo > 0)
                {
                    Console.WriteLine("Es Acredor");
                    suma += saldo;

                }
                else
                {
                    if(saldo < 0)
                    {
                        Console.WriteLine("Es Deudor");
                    }if(saldo == 0)
                    {
                        Console.WriteLine("NULO!");
                    }
                }
        


                

            } while (numCuenta >= 0);
            Console.WriteLine("");
            Console.WriteLine("La suma total de los saldos acreedores: " + suma);
            Console.ReadKey();
        }
    }
}
