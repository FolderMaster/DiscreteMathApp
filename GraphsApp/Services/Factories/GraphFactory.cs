using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GraphsApp.Models.Graphs;
using GraphsApp.Services.Validatories;

namespace GraphsApp.Services.Factories
{
    public static class GraphFactory
    {
        public static Graph CreateGraphByAdjacencyMatrix(int[,] matrix)
        {
            ValueValidator.AssertMatrixIsAdjacency(matrix, nameof(matrix));
            int verticesCount = matrix.GetLength(0);
            List<Vertex> vertices = new List<Vertex>();
            for(int n = 0; n < verticesCount; n++)
            {
                vertices.Add(new Vertex(n.ToString()));
            }
            Graph result = new Graph(vertices);

            int edgesCount = 0;
            for (int y = 0; y < verticesCount; ++y)
            {
                for (int x = y; x < verticesCount; ++x)
                {
                    for(int k = 0; k < matrix[x, y]; ++k)
                    {
                        result.ConnectVertexToVertex(result.Vertices[y], result.Vertices[x], Convert.ToChar((int)'a' + edgesCount).ToString());
                        ++edgesCount;
                    }
                }
            }
            return result;
        }

        public static Graph CreateGraphByIncidenceMatrix(int[,] matrix)
        {
            int edgesCount = matrix.GetLength(0);
            int verticesCount = matrix.GetLength(1);
            Graph result = new Graph(new List<Vertex>(verticesCount));
            for (int y = 0; y < edgesCount; ++y)
            {
                for (int x = 0; x < verticesCount; ++x)
                {
                }
            }
            return result;
        }

        public static Graph CreateRandomGraph(int verticesCount, int edgesCount = -1)
        {
            Graph result = new Graph(new List<Vertex>(verticesCount),
                new List<Edge>(edgesCount == -1 ? verticesCount : edgesCount));
            for(int n = 0; n < result.Edges.Count; ++n)
            {
            }
            return result;
        }
    }
}