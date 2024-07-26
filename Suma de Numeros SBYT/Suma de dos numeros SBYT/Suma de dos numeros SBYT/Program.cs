using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_dos_numeros_SBYT
{
    class Program
    {
        static void Main(string[] args)
        {

            //Suma de dos numeros SBYT

            Console.Write("num 1:");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("num 2:");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            int respuesta = num1 + num2;

            Console.WriteLine("la suma de {0} + {1} = {2}", num1, num2, respuesta);

            //pausa
            Console.ReadLine();
        }
    }
}
