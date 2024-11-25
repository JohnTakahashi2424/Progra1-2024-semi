using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prioridad_operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args){
            //Prioridad de los operadores aritmeticos.
            //se pone el sufijo m para la division con decimales.
            decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1; //valor incorrecto:14.75, Valor correcto: 11.5
            Console.WriteLine("La respuesta es: {0}", respuesta);
            Console.WriteLine("La division de 5/4 es {0}", 5 / 4);
           
            //Pausa.
            Console.ReadLine();
        }
    }
}
