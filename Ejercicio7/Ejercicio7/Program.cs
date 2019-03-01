using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Entra el valor de x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra el valor de y");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Antes del Cambio");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Despues del intercambio");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.ReadLine();
        }
    }
}
