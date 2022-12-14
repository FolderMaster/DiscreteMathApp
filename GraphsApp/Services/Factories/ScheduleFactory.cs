using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                points.Add(new Point(vertex.Name, new List<double> { random.Next(100), 
                    random.Next(100) }));
            }
            List<Curve> curves = new List<Curve>();
            Dictionary<(Vertex, Vertex), int> vertexEdgePairs = new Dictionary<(Vertex, Vertex),
                int>();
            foreach (Edge edge in graph.Edges)
            {
                Vertex vertex1 = edge.Begin;
                Vertex vertex2 = edge.End;
                Point begin = points[graph.Vertices.IndexOf(vertex1)];
                Point end = points[graph.Vertices.IndexOf(vertex2)];

                int count = 0;
                if(vertexEdgePairs.ContainsKey((vertex1, vertex2)))
                {
                    count += vertexEdgePairs[(vertex1, vertex2)];
                    vertexEdgePairs[(vertex1, vertex2)] += 3;
                }
                else if(vertexEdgePairs.ContainsKey((vertex2, vertex1)))
                {
                    count += vertexEdgePairs[(vertex2, vertex1)];
                    vertexEdgePairs[(vertex2, vertex1)] += 3;
                }
                else
                {
                    vertexEdgePairs.Add((vertex1, vertex2), 1);
                }
                vertexEdgePairs.TryGetValue((vertex1, vertex2), out count);

                Point middle = ShapeFactory.CreateCurveMiddlePoint2D(begin, end, count);
                curves.Add(new Curve(edge.Name, begin, middle, end));
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
