using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nota_final_de_computo_1_2_tarea
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial1: ");
            double parcial1 = double.Parse(Console.ReadLine());

            double C1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota del computo 1 es: {0}", C1);


            Console.Write("Lab1C2: ");
            double lab1C2 = double.Parse(Console.ReadLine());

            Console.Write("Lab2C2: ");
            double lab2C2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial2: ");
            double parcial2 = double.Parse(Console.ReadLine());

            double C2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota del computo 2 es: {0}", C2);


            Console.Write("Lab1C3: ");
            double lab1C3 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2C3 = double.Parse(Console.ReadLine());

            Console.Write("Parcial3: ");
            double parcial3 = double.Parse(Console.ReadLine());

            double C3 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota del computo 3 es: {0}", C3);

            double NT = (C1 + C2 + C3) / 3;
            Console.WriteLine("La nota final es de: {0}", NT);
            //pausa
            Console.ReadLine();
        }
    }
}
