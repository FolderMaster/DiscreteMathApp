using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using GraphsApp.Services.App;

namespace GraphsApp.Models.Plots
{
    public class Point : IShape, IComparable, IDrawable
    {
        public string Name { get; set; } = "";

        public Color Color { get; set; } = Color.White;

        public List<double> Coordinates { get; set; } = new List<double>();

        public int AxisCount
        {
            get => Coordinates.Count;
        }

        public Point()
        {
        }

        public Point(IEnumerable<double> coordinates)
        {
            Coordinates = coordinates.ToList();
        }

        public Point(string name, IEnumerable<double> coordinates)
        {
            Name = name;
            Coordinates = coordinates.ToList();
        }

        public Point(string name, Color color, IEnumerable<double> coordinates)
        {
            Name = name;
            Color = color;
            Coordinates = coordinates.ToList();
        }

        public double this[int index]
        {
            get => Coordinates[index];
            set => Coordinates[index] = value;
        }

        public double GetDistance(Point point, IPlot schedule)
        {
            double result = 0;
            for (int n = 0; n < point.Coordinates.Count || n < Coordinates.Count; ++n)
            {
                double coordinate1 = n < Coordinates.Count ? Coordinates[n] :
                    schedule.DefaultValue;
                double coordinate2 = n < point.Coordinates.Count ? point.Coordinates[n] :
                    schedule.DefaultValue;

                result += Math.Pow(coordinate2 - coordinate1, 2);
            }
            return Math.Sqrt(result);
        }

        public IShape Display(IPlot schedule)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < schedule.Axises.Count; ++n)
            {
                if (n < Coordinates.Count)
                {
                    coordinates.Add(schedule.Axises[n].Display(Coordinates[n]));
                }
                else
                {
                    coordinates.Add(schedule.DefaultValue);
                }
            }
            return new Point(Name, Color, coordinates);
        }

        public double GetMax(IPlot schedule, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : schedule.DefaultValue;
        }

        public double GetMin(IPlot schedule, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : schedule.DefaultValue;
        }

        public override string ToString()
        {
            return string.Join(";", Coordinates);
        }

        public int CompareTo(object obj)
        {
            if (obj is Point point)
            {
                List<double> coordinates = point.Coordinates;
                for (int n = 0; n < coordinates.Count && n < Coordinates.Count; ++n)
                {
                    if (coordinates[n] < Coordinates[n])
                    {
                        return 1;
                    }
                    else if (coordinates[n] > Coordinates[n])
                    {
                        return -1;
                    }
                }
                if (coordinates.Count < Coordinates.Count)
                {
                    return 1;
                }
                else if (coordinates.Count < Coordinates.Count)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void Draw(Graphics graphics, Settings settings, int height, int width)
        {
            int x = (int)this[0];
            int y = (int)this[1];

            graphics.DrawEllipse(settings.OuterPointPen, x - settings.PointSize / 2, height
                - y - settings.PointSize / 2, settings.PointSize, settings.PointSize);
            graphics.FillEllipse(new SolidBrush(Color), x - settings.PointSize / 2,
                height - y - settings.PointSize / 2, settings.PointSize, settings.PointSize);
            graphics.DrawString(Name, settings.ValueFont, settings.FontSolidBrush,
                x, height - y);
        }
    }
}