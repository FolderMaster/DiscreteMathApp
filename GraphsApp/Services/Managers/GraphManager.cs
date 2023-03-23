using System;
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
                if (unusedColors.Count > 0)
                {
                    ColorVertecies(uncoloredVertexes, unusedColors);
                }
                else
                {
                    throw new ArgumentException("Need more colors than there are!");
                }
            }
        }

        public static void ColorVertecies(List<Vertex> uncoloredVertexes, List<Color> unusedColors)
        {
            List<Vertex> avaibleVertexes = new List<Vertex>();
            foreach(Vertex vertex in uncoloredVertexes)
            {
                bool isAvaible = true;
                foreach(Vertex avaibleVertex in avaibleVertexes)
                {
                    if(avaibleVertex.Edges.Where((e) => e.Begin == vertex || e.End == vertex).Any()
                        || vertex.Edges.Where((e) => e.Begin == avaibleVertex ||
                        e.End == avaibleVertex).Any())
                    {
                        isAvaible = false;
                        break;
                    }
                }
                if(isAvaible)
                {
                    avaibleVertexes.Add(vertex);
                }
            }

            foreach (Vertex vertex in avaibleVertexes)
            {
                vertex.Color = unusedColors[0];
                uncoloredVertexes.Remove(vertex);
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

            return degreeAndVertexPair.OrderByDescending((v) => v.Item1).Select((v) => v.Item2).
                ToList();
        }

        public static (double, List<Edge>) GetLengthOfShortestPath(Graph graph, Vertex fromVertex,
            Vertex toVertex)
        {
            (double, List<Edge>)[,] matrix = FloydAlgorithm(WeightMatrix(graph));
            if(fromVertex != null && toVertex != null)
            {
                (double, List<Edge>) result = matrix[graph.Vertices.IndexOf(fromVertex),
                    graph.Vertices.IndexOf(toVertex)];
                graph.Edges.ForEach((edge) => edge.isOutlined = false);
                result.Item2.ForEach((edge) => edge.isOutlined = true);
                return result;
            }
            else
            {
                throw new ArgumentException("The vertex from which the path starts/where the " +
                    "path ends is not specified!");
            }
        }

        public static (double, List<Edge>)[,] FloydAlgorithm((double, List<Edge>)[,] weightMatrix)
        {
            int vertexCount = weightMatrix.GetLength(0);
            for (int k = 0; k < vertexCount; ++k)
            {
                for (int i = 0; i < vertexCount; ++i)
                {
                    for(int j = 0; j < vertexCount; ++j)
                    {
                        if (weightMatrix[i, k].Item1 + weightMatrix[k, j].Item1 <
                            weightMatrix[i, j].Item1)
                        {
                            weightMatrix[i, j].Item1 = weightMatrix[i, k].Item1 +
                                weightMatrix[k, j].Item1;

                            weightMatrix[i, j].Item2.Clear();
                            weightMatrix[i, j].Item2.AddRange(weightMatrix[i, k].Item2);
                            weightMatrix[i, j].Item2.AddRange(weightMatrix[k, j].Item2);
                        }
                    }
                }
            }
            return weightMatrix;
        }

        public static (double, List<Edge>)[,] WeightMatrix(Graph graph)
        {
            int vertexCount = graph.Vertices.Count;
            (double, List<Edge>)[,] result = new (double, List<Edge>)[vertexCount, vertexCount];
            for(int y = 0; y < vertexCount; ++y)
            {
                for (int x = 0; x < vertexCount; ++x)
                {
                    Vertex fromVertex = graph.Vertices[y];
                    if (x == y)
                    {
                        result[y, x] = (0, new List<Edge>());
                    }
                    else
                    {
                        Vertex toVertex = graph.Vertices[x];
                        IEnumerable<Edge> edges = graph.Edges.Where((edge) => ((edge.Begin ==
                            fromVertex && edge.End == toVertex) || (edge.Begin == toVertex &&
                            edge.End == fromVertex)) && fromVertex.Edges.Contains(edge));
                        if (edges.Count() > 0)
                        {
                            double minWeight = edges.Min((edge) => edge.Weight);
                            Edge minEdge = edges.First((edge) => edge.Weight == minWeight);
                            result[y, x] = (minWeight, new List<Edge>() { minEdge });
                        }
                        else
                        {
                            result[y, x] = (double.PositiveInfinity, new List<Edge>());
                        }
                    }
                }
            }
            return result;
        }
    }
}