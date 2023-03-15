using GraphsApp.Services.Factories;
using GraphsApp.Services.Validatories;
using System;

namespace GraphsApp.Services.Managers
{
    public static class MatrixManager
    {
        public static int[,] Pow(int[,] matrix, int degree)
        {
            ValueValidator.AssertIsNotNull(matrix, nameof(matrix));
            ValueValidator.AssertMatrixOnLengthesAreEqual(matrix, nameof(matrix));
            int length = matrix.GetLength(0);
            int[,] result = matrix;
            for(int d = 1; d < degree; ++d)
            {
                int[,] temp = new int [length, length];
                for (int y = 0; y < length; ++y)
                {
                    for (int x = 0; x < length; ++x)
                    {
                        for(int n = 0; n < length; ++n)
                        {
                            temp[y, x] += result[y, n] * matrix[n, x];
                        }
                    }
                }
                result = temp;
            }
            return result;
        }
    }
}