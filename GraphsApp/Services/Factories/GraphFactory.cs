using System;
using System.Collections.Generic;
using GraphsApp.Models.Graphs;
using GraphsApp.Services.Validatories;

namespace GraphsApp.Services.Factories
{
    public static class GraphFactory
    {
        public static Graph CreateGraphByAdjacencyMatrix(int[,] matrix)
        {
            ValueValidator.AssertMatrixIsAdjacency(matrix, nameof(matrix));
            int sizeMatrix = matrix.GetLength(0);
            Graph result = new Graph(new List<Vertex>(sizeMatrix));
            for (int y = 0; y < sizeMatrix; ++y)
            {
                for (int x = 0; x < sizeMatrix; ++x)
                {
                    int count = y == x ? matrix[x, y] / 2 : matrix[x, y];
                    for(int k = 0; k < count; ++k)
                    {
                        result.ConnectVertices(result.Vertices[y], result.Vertices[x]);
                    }
                }
            }
            return result;
        }
    }
}