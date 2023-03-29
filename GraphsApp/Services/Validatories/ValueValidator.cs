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

        public static void AssertValueIsPositive(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        public static void AssertValueIsInRange(int value, int min, bool isMinInclude, int max,
            bool isMaxInclude, string name)
        {
            if(!((!isMinInclude && min < value) || (isMinInclude && min <= value)) ||
                !((!isMaxInclude && value < max) || (isMaxInclude && value <= max)))
            {
                string leftBracket = isMinInclude ? "[" : "(";
                string rightBracket = isMaxInclude ? "]" : ")";
                throw new ArgumentException($"{name} must be in range {leftBracket}{min}; {max}" +
                    $"{rightBracket}");
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
            int verticesCount = matrix.GetLength(0);
            for(int y = 0; y < verticesCount; ++y)
            {
                for(int x = 0; x < verticesCount; ++x)
                {
                    AssertValueIsPositive(matrix[y, x], $"{name}[{y}, {x}]");
                }
            }
        }

        public static void AssertMatrixIsIncidence(int[,] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            int edgesCount = matrix.GetLength(1);
            int verticesCount = matrix.GetLength(0);
            for (int x = 0; x < edgesCount; ++x)
            {
                bool isToVertex = false;
                bool isFromVertex = false;
                for (int y = 0; y < verticesCount; ++y)
                {
                    AssertValueIsInRange(matrix[y, x], -1, true, 2, true, $"{name}[{y}, {x}]");
                    switch (matrix[y, x])
                    {
                        case -1:
                            if (!isFromVertex)
                            {
                                isFromVertex = true;
                            }
                            else
                            {
                                throw new ArgumentException("Found 2 vertices from which an " +
                                    $"edge goes, in {name}'s {x} column.");
                            }
                            break;
                        case 1:
                            if (!isToVertex)
                            {
                                isToVertex = true;
                            }
                            else if(!isFromVertex)
                            {
                                isFromVertex = true;
                            }
                            else
                            {
                                throw new ArgumentException("Found addable vertex with vertices " +
                                    $"from and to which an edge goes, in {name}'s {x} column.");
                            }
                            break;
                        case 2:
                            if (!isFromVertex && !isToVertex)
                            {
                                isFromVertex = true;
                                isToVertex = true;
                            }
                            else
                            {
                                throw new ArgumentException("Found connetionable vertex with " +
                                    $"loop, in {name}'s {x} column.");
                            }
                            break;
                    }
                }
                if(!isFromVertex || !isToVertex)
                {
                    throw new ArgumentException("Not found vertices from and to which an edge " +
                        $"goes, in {name}'s {x} column.");
                }
            }
        }
    }
}