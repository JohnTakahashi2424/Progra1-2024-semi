using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prioridad_de_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prioridad de una serie de Numeros
            int[] serie = new int[] { 5, 4, 4, 6, 8, 9 };
            int suma = 0;
            foreach (int num in serie)
            {
                suma += num;
            }
            double prom = suma / serie.Length;
            Console.WriteLine("La suma es: {0}, el promedio {1}", suma, suma / prom);

            //pausa
            Console.ReadLine();
        }
    }
}
