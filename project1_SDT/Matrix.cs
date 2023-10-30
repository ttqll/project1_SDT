using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_SDT
{
    public static class Matrix
    {
        public static double[,] CreateMatrix(int rowCount, int columnCount)
        {
            return new double[rowCount, columnCount];
        }
        public static double[,] CreateMatrix(int size)
        {
            return new double[size, size];
        }
        public static void FillMatrix(double[,] matrix)
        {
            Random rnd = new();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = Math.Round(rnd.NextDouble(), 2);
                }
            }
        }

        public static void ShowMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] TranspanentMatrix(double[,] matrix)
        {
            double[,] resultMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    resultMatrix[i,j] = matrix[j,i];    
                }
            }
            return resultMatrix;

        }
    }
}
