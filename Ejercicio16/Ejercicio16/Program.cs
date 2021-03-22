using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor: ");
            if(Int32.TryParse(Console.ReadLine(), out int valor))
            {
                Console.Write("El valor puede interpretarse como entero");
            }
            else
            {
                Console.Write("El valor no puede interpretarse como entero");
            }
            Console.ReadKey();
        }
    }
}
