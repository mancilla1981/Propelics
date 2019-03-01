using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cadena");

            int[] arreglo= new int[6];

            for (int i=0; i<=5; i++)
            {
                arreglo[i] = Convert.ToInt32( Console.ReadLine());
            }

            Reversa(arreglo, 0, 5);
            Console.Write("Inverso es: \n");
            printArreglo(arreglo, 6);
            Console.ReadLine();
        }

        static void Reversa(int[] Arreglo, int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = Arreglo[start];
                Arreglo[start] = Arreglo[end];
                Arreglo[end] = temp;
                start++;
                end--;
            }

        }
        static void printArreglo(int[] Arreglo,int Largo)
        {
            for (int i = 0; i < Largo; i++)
                Console.Write(Arreglo[i] + " ");

            Console.WriteLine();
        }
    }
}
