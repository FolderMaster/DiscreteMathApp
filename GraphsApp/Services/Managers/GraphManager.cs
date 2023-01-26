using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Services.Managers
{
    public static class GraphManager
    {
        public static void ColorGraph(Graph graph, List<Color> unusedColors)
        {
            List<Vertex> uncoloredVertexes = SortedByVertexDegree(graph);
            while (uncoloredVertexes.Count > 0)
            {
                ColorVertecies(uncoloredVertexes, unusedColors);
            }
        }

        public static void ColorVertecies(List<Vertex> uncoloredVertexes, List<Color> unusedColors)
        {
            Vertex currentVertex = uncoloredVertexes[0];
            List<Vertex> unavaibleVertexes = new List<Vertex>();
            for (int i = 0; i < currentVertex.Edges.Count; i++)
            {
                Vertex endVertex = currentVertex.Edges[i].End;
                Vertex beginVertex = currentVertex.Edges[i].Begin;
                if (!unavaibleVertexes.Contains(endVertex) && currentVertex != endVertex)
                {
                    unavaibleVertexes.Add(endVertex);
                }
                if (!unavaibleVertexes.Contains(beginVertex) && currentVertex != beginVertex)
                {
                    unavaibleVertexes.Add(beginVertex);
                }
            }
            List<Vertex> avaibleVertexes = new List<Vertex>();
            foreach (Vertex vertex in uncoloredVertexes)
            {
                if (!unavaibleVertexes.Contains(vertex))
                {
                    avaibleVertexes.Add(vertex);
                }
            }
            foreach (Vertex avaibleVertex in avaibleVertexes)
            {
                avaibleVertex.Color = unusedColors[0];
                uncoloredVertexes.Remove(avaibleVertex);
            }
            unusedColors.RemoveAt(0);
        }

        public static List<Vertex> SortedByVertexDegree(Graph graph)
        {
            List<(int, Vertex)> degreeAndVertexPair = new List<(int, Vertex)>();
            for (int i = 0; i < graph.Vertices.Count; i++)
            {
                Vertex currentVertex = graph.Vertices[i];
                degreeAndVertexPair.Add((currentVertex.Edges.Count, currentVertex));
            }
            List<(int, Vertex)> sortedTuples =
                degreeAndVertexPair.OrderByDescending(x => x.Item1).ToList();
            List<Vertex> sortedVertexes = new List<Vertex>();
            foreach ((int, Vertex) tuple in sortedTuples)
            {
                sortedVertexes.Add(tuple.Item2);
            }
            return sortedVertexes;
        }

        public static double GetLengthOfShortestPath(Graph graph, Vertex fromVertex, Vertex
            toVertex)
        {
            double[,] matrix = FloydAlgorithm(WeightMatrix(graph));
            return matrix[graph.Vertices.IndexOf(fromVertex), graph.Vertices.IndexOf(toVertex)];
        }

        public static double[,] FloydAlgorithm(double[,] weightMatrix)
        {
            int vertexCount = weightMatrix.GetLength(0);
            for (int k = 0; k < vertexCount; ++k)
            {
                for (int i = 0; i < vertexCount; ++i)
                {
                    for(int j = 0; j < vertexCount; ++j)
                    {
                        if (weightMatrix[i, k] == weightMatrix[k, j] && i != j)
                        {
                            if (weightMatrix[i, k] + weightMatrix[k, j] < weightMatrix[i, j] ||
                                weightMatrix[i, j] == 0)
                            {
                                weightMatrix[i, j] = weightMatrix[i, k] + weightMatrix[k, j];
                            }
                        }
                    }
                }
            }
            return weightMatrix;
        }

        public static double[,] WeightMatrix(Graph graph)
        {
            int vertexCount = graph.Vertices.Count;
            double[,] result = new double[vertexCount, vertexCount];
            for(int y = 0; y < vertexCount; ++y)
            {
                for (int x = 0; x < vertexCount; ++x)
                {
                    if(x == y)
                    {
                        result[y, x] = 0;
                    }
                    else
                    {
                        IEnumerable<Edge> edges = graph.Edges.Where((edge) => edge.Begin ==
                            graph.Vertices[y] && edge.End == graph.Vertices[x]);
                        if(edges.Count() > 0)
                        {
                            result[y, x] = edges.Min((edge) => edge.Weight);
                        }
                        else
                        {
                            result[y, x] = double.PositiveInfinity;
                        }
                    }
                }
            }
            return result;
        }
    }
}