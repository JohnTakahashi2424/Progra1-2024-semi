using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Conversor
{
    class Program
    {
        static void Main(string[] args)

        { //Conversor de Area (Superficie)

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Selecciona una opcion de estas dos");
                Console.WriteLine("1. Conversor de Areas");
                Console.WriteLine("2. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:

                        Conversor("Areas", new string[] { "Pie cuadrado", "vara cuadrada", "Yarda cuadrada", "metro cuadrada", "unidad de tareas", "Manzanas", "Hectareas" },
                        new double[,] {
                { 1, 0.132, 0.111, 0.0929, 0.0001477465648855, 0.000018, 0.0000093},
                { 9, 1, 1 , 0.8361, 0.000223 , 0.000164, 0.0000836},
                { 10.764 , 1.196 , 1 , 1 , 0.000247, 0.0002 , 0.0001 },
                { 107.64 , 11.96 , 11.96, 10 , 0.00247, 0.002 , 0.001 },
                { 10764, 1195.99 , 1195.99 , 1000, 0.247, 0.2 , 0.1 },
                { 538195.52, 59799.52 , 59799.52 , 49874.3 , 12.36 , 10 , 5},
                { 107639.1 , 11959.9 , 11959.9 , 10000 , 2.471 , 2, 1}
                        });


                        break; //lo que hace es que el bucle termine inmediatamente.

                    case 2:
                        continuar = false;
                        Console.WriteLine("¡Gracias por tu trabajo!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                        break;

                }
            }
        }
        static void Conversor(string tipo, string[] unidades, double[,] conversiones)
        {
            Console.Clear();
            Console.WriteLine($"Conversor de {tipo}");
            Console.WriteLine("Unidades disponibles para escoger:");
            for (int i = 0; i < unidades.Length; i++)     // en esta defino e inicializo una variable de control del bucle, lo que sera entero
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }

            // Solicita al usuario la unidad de origen
            Console.Write("Selecciona la unidad que usaras: ");
            int origen = int.Parse(Console.ReadLine()) - 1;

            // Solicita al usuario la unidad del destino
            Console.Write("Selecciona la unidad  en la que lo convertiras: ");
            int destino = int.Parse(Console.ReadLine()) - 1;

            // Solicita al usuario el valor a convertir
            Console.Write("Introduce el dato a convertir: ");
            double valor = double.Parse(Console.ReadLine());

            // Y este Realizara la conversión utilizando la matriz de las conversiones
            double resultado = valor * conversiones[origen, destino];
            Console.WriteLine($"{valor} {unidades[origen]} = {resultado} {unidades[destino]}");
            Console.WriteLine("Presiona cualquier tecla del teclado para continuar...");
            Console.ReadKey();




        }

    }

}

        
   
