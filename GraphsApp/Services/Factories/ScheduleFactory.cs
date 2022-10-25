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
            List<Axis> axises = new List<Axis> { new Axis(new LinearScale(), (min) => min * 0.5, (max) => max * 1.3),
                new Axis(new LinearScale(), (min) => min * 0.5, (max) => max * 1.3)};
            result.Axises2D = axises;
            List<Point> points = new List<Point>();
            foreach (Vertex vertex in graph.Vertices)
            {
                points.Add(new Point(vertex.Name, new List<double> { random.Next(100), random.Next(100) }));
            }
            List<LineSegment> lines = new List<LineSegment>();
            foreach (Edge edge in graph.Edges)
            {
                Vertex vertex1 = edge.Begin;
                Vertex vertex2 = edge.End;
                Point point1 = points[graph.Vertices.IndexOf(vertex1)];
                Point point2 = points[graph.Vertices.IndexOf(vertex2)];
                lines.Add(new LineSegment(edge.Name, point1, point2));
            }
            foreach(Point point in points)
            {
                result.Shapes.Add(point);
            }
            foreach (LineSegment line in lines)
            {
                result.Shapes.Add(line);
            }
            return result;
        }
    }
}
