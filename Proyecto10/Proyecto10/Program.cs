using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) {

                Console.Write(num1 + " es mayor que " + num2);
            }
            else
            {
                Console.Write(num2 + " es mayor que " + num1);
            }
            Console.ReadKey();
        }
    }
}
