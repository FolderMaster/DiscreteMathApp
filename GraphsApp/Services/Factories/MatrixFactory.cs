using System;

namespace GraphsApp.Services.Factories
{
    public static class MatrixFactory
    {
        public static int[,] CreateAdjacencyMatrix(int verticesCount, int edgesCount, 
            int loopsCount = 0, int edgeMultiplicity = 0)
        {
            Random random = new Random();
            int[,] result = new int[verticesCount, verticesCount];
            for(int y = 0; y < verticesCount; ++y)
            {
                for(int x = y; x < verticesCount; ++x)
                {
                    int generatedValue;
                    if (y == x)
                    {
                        generatedValue = random.Next(Math.Min(edgesCount, Math.Min(loopsCount,
                            edgeMultiplicity)) + 1);
                        result[y, x] = generatedValue;
                        loopsCount -= generatedValue;
                    }
                    else
                    {
                        generatedValue = random.Next(Math.Min(edgesCount, edgeMultiplicity) + 1);
                        result[x, y] = result[y, x] = generatedValue;
                    }
                    edgesCount -= generatedValue;
                }
            }
            return result;
        }

        public static int[,] CreateIncidentMatrix(int verticesCount, int edgesCount,
            int loopsCount = 0, int edgeMultiplicity = 0)
        {
            Random random = new Random();
            int[,] result = new int[verticesCount, edgesCount];
            for (int y = 0; y < verticesCount; ++y)
            {
                for (int x = 0; x < edgesCount; ++x)
                {
                    int generatedValue = random.Next(verticesCount > 0 ? loopsCount > 0 ? 3 : 2 : 1);
                }
            }
            return result;
        }
    }
}