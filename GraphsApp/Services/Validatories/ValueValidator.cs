using System;

namespace GraphsApp.Services.Validatories
{
    public static class ValueValidator
    {
        public static void AssertIsNotNull<T>(T value, string name)
        {
            if (value == null)
            {
                throw new ArgumentException($"{name} must be not null");
            }
        }

        public static void AssertValueIsEven(int value, string name)
        {
            if (value % 2 == 1)
            {
                throw new ArgumentException($"{name} must be even");
            }
        }

        public static void AssertValueIsPositive(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        public static void AssertMatrixOnLengthesAreEqual<T>(T[,] matrix, string name)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException($"Lengthes of {name} must be equal");
            }
        }

        public static void AssertMatrixIsAdjacency(int[,] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            AssertMatrixOnLengthesAreEqual(matrix, name);
            int matrixSize = matrix.GetLength(0);
            for(int y = 0; y < matrixSize; ++y)
            {
                for(int x = 0; x < matrixSize; ++x)
                {
                    int value = matrix[y, x];
                    AssertValueIsPositive(value, $"{name}[{y}, {x}]");
                    if(y == x)
                    {
                        AssertValueIsEven(value, $"{name}[{y}, {x}]");
                    }
                }
            }
        }
    }
}
