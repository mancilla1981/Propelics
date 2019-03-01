using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[,] mat = {
    { 1, 2, 3},
    { 4, 0, 6 },
    { 7, 8, 9 }};


            convertir(mat);

            PrintMatriz(mat);
            Console.ReadLine();
        }

        private static void convertir(int[,] matriz)
        {
            bool rowFlag = false, colFlag = false;

            // Filas 0's
            for (int j = 0; j < 3; j++)
                if (matriz[0,j]==0)
                {
                    rowFlag = true;
                    break;
                }

            // Columnas 0's	
            for (int i = 0; i < 3; i++)
                if (matriz[i,0]==0)
                {
                    colFlag = true;
                    break;
                }

            
            for (int i = 1; i < 3; i++)
                for (int j = 1; j < 3; j++)
                    if (matriz[i,j]==0)
                        matriz[0,j] = matriz[i,0] = 0;


            // if (0, j) or (i, 0) is 0, assign 0 to cell (i, j)
            for (int i = 1; i < 3; i++)
                for (int j = 1; j < 3; j++)
                    if (matriz[0,j]==0 || matriz[i,0]==0)
                        matriz[i,j] = 0;

            // if rowFlag is true, then assign 0 to all cells of first row
            for (int i = 0; rowFlag && i < 3; i++)
                matriz[0,i] = 0;

            // if colFlag is true, then assign 0 to all cells of first column
            for (int i = 0; colFlag && i < 3; i++)
                matriz[i,0] = 0;
        }
    

        private static void PrintMatriz(int[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
    
}
