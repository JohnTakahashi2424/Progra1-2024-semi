using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuesto_a_las_Actividades
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[,]
              {

                 { 0.01, 500, 1.5, 0 },
                { 500.01, 1000, 1.5, 3 },
                 { 1000.01, 2000, 3, 3 },
                 { 2000.01, 3000, 6, 3 },
                { 3000.01, 6000, 9, 2 },
                { 8000.01, 18000, 15, 2 },
                { 18000.01, 30000, 39, 2 },
                { 30000.01, 60000, 63, 1 },
                { 60000.01, 100000, 93, 0.8 },
                { 100000.01, 200000, 125, 0.7 },
                { 200000.01, 300000, 195, 0.6 },
                { 300000.01, 400000, 255, 0.45 },
                { 400000.01, 500000, 300, 0.4 },
                { 500000.01, 1000000, 340, 0.3 },
                { 1000000.01, 99999999, 490, 0.18 }
          };

            Console.Write("Introduce el monto: ");
            double monto = Convert.ToDouble(Console.ReadLine());

            double impuesto = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                if (monto >= matriz[i, 0] && monto <= matriz[i, 1])
                {

                    double excedente = monto - matriz[i, 0];
                    impuesto = (excedente / 1000) * matriz[i, 3] + matriz[i, 2];
                    break;
                }
            }

            Console.WriteLine($"El impuesto a pagar es: ${Math.Round(impuesto, 2)}");

            Console.ReadLine();
        }
    }
}
