using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList str1 = new ArrayList();

            Console.WriteLine("Escribe los 4 valores de la primera cadena a comparar");


            str1.Add(Console.ReadLine());
            str1.Add(Console.ReadLine());
            str1.Add(Console.ReadLine());
            str1.Add(Console.ReadLine());

            ArrayList str2 = new ArrayList();
            Console.WriteLine("Escribe los 4 valores de la segunda cadena a comparar");

            str2.Add(Console.ReadLine());
            str2.Add(Console.ReadLine());
            str2.Add(Console.ReadLine());
            str2.Add(Console.ReadLine());

            if (Anagrama(str1, str2))
            {
                Console.WriteLine("Las dos cadenas son anagramas");
            }
            else
            {
                Console.WriteLine("Las dos cadenas No son anagramas");
            }
            Console.ReadLine();
        }

        public static bool Anagrama(ArrayList str1,
                                  ArrayList str2)
        {
            int n1 = str1.Count;
            int n2 = str2.Count;

            if (n1 != n2)
            {
                return false;
            }

            str1.Sort();
            str2.Sort();


            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}