using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            string Cadena;

            Console.WriteLine("Ingresa la cadena");
            Cadena =Console.ReadLine();
            var Resultado = Comprimir(Cadena);

            Console.WriteLine(Resultado);
            Console.ReadLine();
        }

        public static string Comprimir(string Cadena)
        {
            var size = Contar(Cadena);

            if (size >= Cadena.Length)
            {
                return Cadena;
            }

            var sb = new StringBuilder();
            var last = Cadena[0];
            var count = 1;

            for (var i = 1; i < Cadena.Length; i++)
            {
                if (Cadena[i] == last)
                {
                    count++;
                }
                else
                {
                    sb.Append(last);
                    sb.Append(count);
                    last = Cadena[i];
                    count = 1;
                }
            }
            sb.Append(last);
            sb.Append(count);

            return sb.ToString();
        }

        private static int Contar(string Cadena)
        {
            if (string.IsNullOrEmpty(Cadena))
            {
                return 0;
            }

            var last = Cadena[0];
            var size = 0;
            var count = 0;

            for (var i = 1; i < Cadena.Length; i++)
            {
                if (Cadena[i] == last)
                {
                    count++;
                }
                else
                {
                    last = Cadena[i];
                    size += 1 + string.Format("{0}", count).Length;
                    count = 1;
                }
            }

            size += 1 + string.Format("{0}", count).Length;

            return size;
        }

    }
}
