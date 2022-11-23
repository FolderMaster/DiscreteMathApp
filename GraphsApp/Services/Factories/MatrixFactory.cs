using System;

namespace GraphsApp.Services.Factories
{
    public static class MatrixFactory
    {
        public static int[,] CreateAdjacencyMatrix(int verticesCount, int loopsCount = 0, int
            edgeMultiplicity = 0)
        {
            Random random = new Random();
            int[,] result = new int[verticesCount, verticesCount];
            for(int y = 0; y < verticesCount; ++y)
            {
                for(int x = y; x < verticesCount; ++x)
                {
                    if(y == x)
                    {
                        if(loopsCount > 0)
                        {
                            int generatedValue = random.Next(edgeMultiplicity + 1);
                            result[y, x] = generatedValue;
                            loopsCount -= generatedValue;
                        }
                    }
                    else
                    {
                        result[x, y] = result[y, x] = random.Next(edgeMultiplicity + 1);
                    }
                }
            }
            return result;
        }

        public static int[,] CreateNullMatrix(int x, int y)
        {
            return new int[x, y];
        }
    }
}