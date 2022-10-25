using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsApp.Services.Factories
{
    public static class MatrixFactory
    {
        public static int[,] CreateAdjacencyMatrix(int verticesCount, int loopsCount, int edgeMultiplicity = 1)
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
                        result[y, x] = random.Next(edgeMultiplicity + 1);
                        result[x, y] = result[y, x];
                    }
                }
            }
            return result;
        }
    }
}