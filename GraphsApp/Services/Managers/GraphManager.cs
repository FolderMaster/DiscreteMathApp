using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Services.Managers
{
    /// <summary>
    /// Класс поддержки графов с методами взаимодействия с ним.
    /// </summary>
    public static class GraphManager
    {
        /// <summary>
        /// Раскрашивает граф.
        /// </summary>
        /// <param name="graph">Граф.</param>
        /// <param name="colors">Цвета.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void ColorGraph(Graph graph, List<Color> colors)
        {
            List<Vertex> uncoloredVertexes = SortedByVertexDegree(graph);
            while (uncoloredVertexes.Count > 0)
            {
                if (colors.Count > 0)
                {
                    ColorVertices(uncoloredVertexes, colors);
                }
                else
                {
                    throw new ArgumentException("Need more colors than there are!");
                }
            }
        }

        /// <summary>
        /// Раскрашивает вершины.
        /// </summary>
        /// <param name="uncoloredVertexes">Нераскрашенные вершины.</param>
        /// <param name="unusedColors">Неиспользованные цвета.</param>
        public static void ColorVertices(List<Vertex> uncoloredVertexes, List<Color> unusedColors)
        {
            List<Vertex> availedVertexes = new List<Vertex>();
            foreach(Vertex vertex in uncoloredVertexes)
            {
                bool isAvailed = true;
                foreach(Vertex availedVertex in availedVertexes)
                {
                    if(availedVertex.Edges.Where((e) => e.Begin == vertex || e.End == vertex).Any()
                        || vertex.Edges.Where((e) => e.Begin == availedVertex ||
                        e.End == availedVertex).Any())
                    {
                        isAvailed = false;
                        break;
                    }
                }
                if(isAvailed)
                {
                    availedVertexes.Add(vertex);
                }
            }

            foreach (Vertex vertex in availedVertexes)
            {
                vertex.Color = unusedColors[0];
                uncoloredVertexes.Remove(vertex);
            }
            unusedColors.RemoveAt(0);
        }

        /// <summary>
        /// Сортирует вершины по степени.
        /// </summary>
        /// <param name="graph">Граф.</param>
        /// <returns>Список вершин, отсортированных по степени.</returns>
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

        /// <summary>
        /// Находит самый короткий путь.
        /// </summary>
        /// <param name="graph">Граф.</param>
        /// <param name="fromVertex">Вершина, из которой начинается путь.</param>
        /// <param name="toVertex">Вершина, в которой заканчивается путь.</param>
        /// <returns>Кортеж с самым коротким путём и его длиной.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static (double, List<Edge>) GetShortestPath(Graph graph, Vertex fromVertex,
            Vertex toVertex)
        {
            (double, List<Edge>)[,] matrix = GetShortestPathByFloydAlgorithm(GetWeightMatrix(graph));
            if(fromVertex != null && toVertex != null)
            {
                (double, List<Edge>) result = matrix[graph.Vertices.IndexOf(fromVertex),
                    graph.Vertices.IndexOf(toVertex)];
                graph.Edges.ForEach((edge) => edge.IsOutlined = false);
                result.Item2.ForEach((edge) => edge.IsOutlined = true);
                return result;
            }
            else
            {
                throw new ArgumentException("The vertex from which the path starts/where the " +
                    "path ends is not specified!");
            }
        }

        /// <summary>
        /// Находит самый короткий путь алгоритмом Флойда.
        /// </summary>
        /// <param name="weightMatrix">Матрица весов с путями.</param>
        /// <returns>Кортеж с самым коротким путём и его длиной.</returns>
        public static (double, List<Edge>)[,] GetShortestPathByFloydAlgorithm((double,
            List<Edge>)[,] weightMatrix)
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

        /// <summary>
        /// Рассчитывает матрицу весов с путями.
        /// </summary>
        /// <param name="graph">Граф.</param>
        /// <returns>Матрица весов с путями.</returns>
        public static (double, List<Edge>)[,] GetWeightMatrix(Graph graph)
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