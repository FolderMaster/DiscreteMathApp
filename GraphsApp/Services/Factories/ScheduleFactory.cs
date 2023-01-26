using System;
using System.Collections.Generic;

using GraphsApp.Models.Graphs;
using GraphsApp.Models.Schedules;

namespace GraphsApp.Services.Factories
{
    public static class ScheduleFactory
    {
        public static Schedule2D CreateScheduleByGraph(Graph graph)
        {
            Random random = new Random();
            Schedule2D result = new Schedule2D();
            List<Axis> axises = new List<Axis> { new Axis(new LinearScale(), (min) => min - 10, 
                (max) => max + 10), new Axis(new LinearScale(), (min) => min - 10, (max) => 
                max + 10)};
            result.Axises2D = axises;
            List<Point> points = new List<Point>();
            foreach (Vertex vertex in graph.Vertices)
            {
                points.Add(new Point(vertex.Name, vertex.Color, new List<double> { random.Next(100), 
                    random.Next(100) }));
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
                    curves.Add(new Curve(edge.Name, begin, middle, end));
                }
                else
                {
                    int count = 1;
                    Point begin = points[graph.Vertices.IndexOf(vertex1)];
                    if (vertexEdgePairs.ContainsKey((vertex1, vertex2)))
                    {
                        count += 2 * vertexEdgePairs[(vertex1, vertex2)];
                        vertexEdgePairs[(vertex1, vertex2)] += 1;
                    }
                    else if (vertexEdgePairs.ContainsKey((vertex2, vertex1)))
                    {
                        count -= 2 * vertexEdgePairs[(vertex2, vertex1)];
                        vertexEdgePairs[(vertex2, vertex1)] += 1;
                    }
                    else
                    {
                        vertexEdgePairs.Add((vertex1, vertex2), 1);
                    }
                    Point end = ShapeFactory.CreateCurveMiddlePoint2D(begin, begin, count);
                    Point right = ShapeFactory.CreateCurveMiddlePoint2D(begin, end, count);
                    Point left = ShapeFactory.CreateCurveMiddlePoint2D(begin, end, -count);

                    curves.Add(new Curve(edge.Name, begin, right, end));
                    curves.Add(new Curve(begin, left, end));
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
