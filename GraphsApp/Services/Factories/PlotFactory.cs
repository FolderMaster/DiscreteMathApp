using System;
using System.Collections.Generic;
using System.Drawing;

using GraphsApp.Models.Graphs;
using GraphsApp.Models.Plots;

using Point = GraphsApp.Models.Plots.Point;

namespace GraphsApp.Services.Factories
{
    /// <summary>
    /// Класс фабрики графиков с методами создания графиков.
    /// </summary>
    public static class PlotFactory
    {
        /// <summary>
        /// Создаёт двухмерный график графа.
        /// </summary>
        /// <param name="graph">Граф.</param>
        /// <param name="isColorVertices">Логическое значение, указывающее, что раскрашивать ли
        /// вершины.</param>
        /// <param name="isOutlinedEdges">Логическое значение, указывающее, что выделять ли
        /// ребра.</param>
        /// <returns>Двухмерный график графа.</returns>
        public static Plot2D CreateScheduleByGraph(Graph graph, bool isColorVertices = false,
            bool isOutlinedEdges = false)
        {
            Random random = new Random();
            Plot2D result = new Plot2D();
            List<Axis> axes = new List<Axis> { new Axis(new LinearScale(), (min) => min - 10, 
                (max) => max + 10), new Axis(new LinearScale(), (min) => min - 10, (max) => 
                max + 10)};
            result.Axes2D = axes;
            List<Point> points = new List<Point>();
            foreach (Vertex vertex in graph.Vertices)
            {
                if(isColorVertices)
                {
                    points.Add(new Point(vertex.Name, vertex.Color, new List<double> { random.Next(100),
                        random.Next(100) }));
                }
                else
                {
                    points.Add(new Point(vertex.Name, new List<double> { random.Next(100),
                        random.Next(100) }));
                }
            }
            List<Curve> curves = new List<Curve>();
            Dictionary<(Vertex, Vertex), int> vertexEdgePairs = new Dictionary<(Vertex, Vertex),
                int>();
            foreach (Edge edge in graph.Edges)
            {
                Vertex vertex1 = edge.Begin;
                Vertex vertex2 = edge.End;
                
                if (vertex1 != vertex2)
                {
                    int count = 0;
                    Point begin = points[graph.Vertices.IndexOf(vertex1)];
                    Point end = points[graph.Vertices.IndexOf(vertex2)];

                    if (vertexEdgePairs.ContainsKey((vertex1, vertex2)))
                    {
                        count += 3 * vertexEdgePairs[(vertex1, vertex2)];
                        vertexEdgePairs[(vertex1, vertex2)] += 1;
                    }
                    else if (vertexEdgePairs.ContainsKey((vertex2, vertex1)))
                    {
                        count -= 3 * vertexEdgePairs[(vertex2, vertex1)];
                        vertexEdgePairs[(vertex2, vertex1)] += 1;
                    }
                    else
                    {
                        vertexEdgePairs.Add((vertex1, vertex2), 1);
                    }

                    Point middle = ShapeFactory.CreateCurveMiddlePoint2D(begin, end, count);

                    Curve curve = new Curve(edge.Name, new List<Point>() { begin, middle, end });
                    if (isOutlinedEdges && edge.IsOutlined)
                    {
                        curve.Color = Color.Red;
                    }
                    if (!vertex1.Edges.Contains(edge) || !vertex2.Edges.Contains(edge))
                    {
                        curve.IsDirected = true;
                    }
                    curves.Add(curve);
                }
                else
                {
                    Point begin = points[graph.Vertices.IndexOf(vertex1)];
                    if (vertexEdgePairs.ContainsKey((vertex1, vertex2)))
                    {
                        vertexEdgePairs[(vertex1, vertex2)] += 1;
                    }
                    else
                    {
                        vertexEdgePairs.Add((vertex1, vertex2), 1);
                    }
                    double count = vertexEdgePairs[(vertex1, vertex2)];
                    Point end = new Point(new List<double>() { begin[0], begin[1] + 2 * count });
                    Point right = new Point(new List<double>() { begin[0] + 0.8 * count,
                        begin[1] + count });
                    Point left = new Point(new List<double>() { begin[0] - 0.8 * count,
                        begin[1] + count });

                    curves.Add(new Curve(edge.Name, new List<Point>() { begin, right, end, left,
                        begin }));
                }
            }
            foreach(Point point in points)
            {
                result.Shapes.Add(point);
            }
            foreach (Curve curve in curves)
            {
                result.Shapes.Add(curve);
            }
            return result;
        }
    }
}