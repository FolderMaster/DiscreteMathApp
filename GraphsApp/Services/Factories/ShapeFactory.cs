using System;
using System.Collections.Generic;

using GraphsApp.Models.Plots;

namespace GraphsApp.Services.Factories
{
    public static class ShapeFactory
    {
        public static Point CreateMiddlePointByPoints(List<Point> points)
        {
            List<double> coordinates = new List<double>();
            foreach (Point point in points)
            {
                for (int n = 0; n < point.AxisCount; ++n)
                {
                    if (n >= coordinates.Count)
                    {
                        coordinates.Add(0);
                    }
                    coordinates[n] += point.Coordinates[n];
                }
            }
            for (int n = 0; n < coordinates.Count; ++n)
            {
                coordinates[n] /= points.Count;
            }
            return new Point(coordinates);
        }

        public static Point CreateCurveMiddlePoint2D(Point begin, Point end, int factor)
        {
            List<double> coordinates = new List<double>();
            List<double> differences = new List<double>();
            for (int n = 0; n < 2; ++n)
            {
                coordinates.Add(begin[n] + end[n]);
                differences.Add(Math.Abs(begin[n] - end[n]));
            }
            for (int n = 0; n < 2; ++n)
            {
                coordinates[n] /= 2;
            }

            if (differences[0] < differences[1])
            {
                coordinates[1] += factor;
            }
            else
            {
                coordinates[0] += factor;
            }

            return new Point(coordinates);
        }
    }
}