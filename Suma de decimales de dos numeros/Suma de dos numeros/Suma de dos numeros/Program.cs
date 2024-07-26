using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma de decimales de dos numeros

            Console.Write("num 1:");
            double num1 = double.Parse(Console.ReadLine()); //"5" ->

            Console.Write("num 2:");
            double num2 = double.Parse(Console.ReadLine());

            Double respuesta = num1 + num2;
            Console.WriteLine("la suma de {0} + {1} = {2}", num1, num2, respuesta);

            //pausa
            Console.ReadLine();
        }
    }
}
