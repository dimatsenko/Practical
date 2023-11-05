using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract2
{
    internal class Matrix
    {
        private int[,] matrix;
        private int size;

        public Matrix(int n)
        {
            size = n;
            matrix = GenerateRandomMatrix(n);
        }

        public int[,] GetMatrix()
        {
            return matrix;
        }

        public int FindMinElement(out int row, out int col)
        {
            int minElement = FindMinElementIndex(out row, out col);
            return minElement;
        }

        public int GetDistanceToDiagonal(int row, int col)
        {
            return row - col;
        }

        private int[,] GenerateRandomMatrix(int n)
        {
            Random random = new Random();
            int[,] generatedMatrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    generatedMatrix[i, j] = random.Next(1, 5);
                }
            }

            return generatedMatrix;
        }

        private int FindMinElementIndex(out int rowIndex, out int colIndex)
        {
            int minElement = matrix[0, 0];
            rowIndex = 0;
            colIndex = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                        rowIndex = i;
                        colIndex = j;
                    }
                }
            }

            return minElement;
        }
    }

}
