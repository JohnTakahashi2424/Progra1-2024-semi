using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructura_for_desde_hasta_incremento
{
    class Program
    {
        static void Main(string[] args){
            string continuar = "s";
            while (continuar == "s"){
                Console.WriteLine("\n\n *** MENU ***");
                Console.WriteLine("1. Promedio Notas");
                Console.WriteLine("2. Promedio Serie Numeros");
                Console.WriteLine("3. Clasificacion edad");
                Console.WriteLine("4. Tabla Multiplicar");
                Console.WriteLine("5. Salir");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();//limpiar la consola
                Console.WriteLine();

                switch (opcion)
                {
                    case 1://if(opcion==1)
                        Promedio();
                        break;
                    case 2: //if(opcion==2)
                        PromedioSerie();
                        break;
                    case 3://if(opcion==3)
                        ClasificacionEdad();
                        break;
                    case 4:
                        tablaMultiplicar();
                        break;
                    case 5://if(opcion==5)
                        continuar = "n";
                        break;
                    default://else
                        Console.WriteLine("opcion incorrecta \n\n");
                        break;
                }
            }
        }

            static void tablaMultiplicar()
                {
                Console.Write("Tabla: ");
                int ntabla = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {//i++ => i = i + 1
                    Console.WriteLine("{0}x{1}={2}", ntabla, i, ntabla * i);
                }
            }
            static void Promedio()
            {
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial1: ");
            double parcial1 = double.Parse(Console.ReadLine());

            double C1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota del computo 1 es: {0} \n\n", C1);


            Console.Write("Lab1C2: ");
            double lab1C2 = double.Parse(Console.ReadLine());

            Console.Write("Lab2C2: ");
            double lab2C2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial2: ");
            double parcial2 = double.Parse(Console.ReadLine());

            double C2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota del computo 2 es: {0} \n\n", C2);


            Console.Write("Lab1C3: ");
            double lab1C3 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2C3 = double.Parse(Console.ReadLine());

            Console.Write("Parcial3: ");
            double parcial3 = double.Parse(Console.ReadLine());

            double C3 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota del computo 3 es: {0}", C3);

            double NT = (C1 + C2 + C3) / 3;
            Console.WriteLine("La nota final es de: {0} \n\n", NT);
        }
            static void PromedioSerie()
            {
                int[] serie = new int[] { 5, 4, 6, 8, 9 }; //32
                int suma = 0;
                foreach (int num in serie)
                {
                    suma += num;
                }
                decimal prom = suma / serie.Length;
                Console.WriteLine("La suma es: {0}, el promedio {1}", suma, prom);
            }
            static void ClasificacionEdad()
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
            if (edad < 0)
            {
                Console.WriteLine("Edad incorrecta.");
            }
            else if (edad <= 2)
            {
                Console.WriteLine("Eres un bebe");
            }
            else if (edad < 12)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad < 18)
            {
                Console.WriteLine("Eres un adolescente.");
            }
            else if (edad <= 65)
            {
                Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
            }
            else if (edad <= 80)
            {
                Console.WriteLine("Eres un adulto mayor");
            }
            else
            {
                Console.WriteLine("Larga vida");
            }


                
            }
    }
}


