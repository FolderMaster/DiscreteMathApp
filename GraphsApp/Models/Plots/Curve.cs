using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

using GraphsApp.Services.App;
using GraphsApp.Services.Factories;

namespace GraphsApp.Models.Plots
{
    public class Curve : IShape, IDrawable
    {
        public string Name { get; set; } = "";

        public Color Color { get; set; } = Color.Black;

        public List<Point> Points { get; set; } = new List<Point>();

        public Point Begin { get; set; } = new Point();

        public Point Middle { get; set; } = new Point();

        public Point End { get; set; } = new Point();

        public bool IsDirected { get; set; } = false;

        public Curve()
        {
        }

        public Curve(List<Point> points)
        {
            Points = points;
        }

        public Curve(Color color, List<Point> points) : this(points)
        {
            Color = color;
        }

        public Curve(string name, List<Point> points) : this(points)
        {
            Name = name;
        }

        public Curve(string name, Color color, List<Point> points) : this(name, points)
        {
            Color = color;
        }

        public Curve(string name, Color color, List<Point> points, bool isDirected) : this(name,
            color, points)
        {
            IsDirected = isDirected;
        }

        public IShape Display(IPlot schedule)
        {
            List<Point> points = new List<Point>();

            for(int n = 0; n < Points.Count; ++n)
            {
                points.Add(new Point());
                for (int a = 0; a < schedule.Axises.Count; ++a)
                {
                    if(a < Points[n].AxisCount)
                    {
                        points[n].Coordinates.Add(
                            schedule.Axises[a].Display(Points[n].Coordinates[a]));
                    }
                    else
                    {
                        points[n].Coordinates[a] = schedule.DefaultValue;
                    }
                }
            }
            return new Curve(Name, Color, points, IsDirected);
        }

        public double GetMax(IPlot schedule, int axisIndex)
        {
            List<double> values = new List<double>();
            foreach (Point point in Points)
            {
                values.Add(axisIndex < point.AxisCount ? point[axisIndex] : schedule.DefaultValue);
            }
            return values.Max();
        }

        public double GetMin(IPlot schedule, int axisIndex)
        {
            List<double> values = new List<double>();
            foreach(Point point in Points)
            {
                values.Add(axisIndex < point.AxisCount ? point[axisIndex] : schedule.DefaultValue);
            }
            return values.Min();
        }

        public override string ToString()
        {
            return string.Join(":", Points);
        }

        public virtual void Draw(Graphics graphics, Settings settings, int height, int width)
        {
            Point middlePoint = ShapeFactory.CreateMiddlePointByPoints(Points);
            List<PointF> pointFs = new List<PointF>();
            foreach(Point point in Points)
            {
                pointFs.Add(new PointF((int)point[0], height - (int)point[1]));
            }
            Pen pen = new Pen(Color);
            if(IsDirected)
            {
                  pen.CustomEndCap = new AdjustableArrowCap(settings.ArrowCapWidth,
                    settings.ArrowCapHeight);
            }

            graphics.DrawCurve(pen, pointFs.ToArray());
            graphics.DrawString(Name, settings.ValueFont, settings.FontSolidBrush,
                (int)middlePoint[0], height - (int)middlePoint[1]);
        }
    }
}