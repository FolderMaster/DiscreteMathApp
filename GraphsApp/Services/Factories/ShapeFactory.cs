using System;
using System.Collections.Generic;

using GraphsApp.Models.Plots;

namespace GraphsApp.Services.Factories
{
    /// <summary>
    /// Класс фабрики фигур с методами создания фигур.
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        /// Создаёт точку середины точек.
        /// </summary>
        /// <param name="points">Точки.</param>
        /// <returns>Точка середины точек.</returns>
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

        /// <summary>
        /// Создаёт двухмерную точку по середине кривой.
        /// </summary>
        /// <param name="begin">Точка начала кривой.</param>
        /// <param name="end">Точка конца кривой.</param>
        /// <param name="deviation">Коэффициент отклонения.</param>
        /// <returns>Двухмерная точка по середине кривой.</returns>
        public static Point CreateCurveMiddlePoint2D(Point begin, Point end, int deviation)
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
                coordinates[1] += deviation;
            }
            else
            {
                coordinates[0] += deviation;
            }

            return new Point(coordinates);
        }
    }
}