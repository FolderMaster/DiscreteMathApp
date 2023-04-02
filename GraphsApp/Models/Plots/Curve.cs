using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

using GraphsApp.Services.App;
using GraphsApp.Services.Factories;

namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Класс кривой с точками.
    /// </summary>
    public class Curve : IShape, IDrawable
    {
        public string Name { get; set; } = "";

        public Color Color { get; set; } = Color.Black;

        /// <summary>
        /// Возвращает и задаёт точки.
        /// </summary>
        public List<Point> Points { get; set; } = new List<Point>();

        /// <summary>
        /// Возвращает и задаёт логическое значение, указывающее, что направлен.
        /// </summary>
        public bool IsDirected { get; set; } = false;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Curve"/> по умолчанию.
        /// </summary>
        public Curve() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Curve"/>.
        /// </summary>
        /// <param name="points">Точки.</param>
        public Curve(List<Point> points)
        {
            Points = points;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Curve"/>.
        /// </summary>
        /// <param name="color">Цвет.</param>
        /// <param name="points">Точки.</param>
        public Curve(Color color, List<Point> points) : this(points)
        {
            Color = color;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Curve"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="points">Точки.</param>
        public Curve(string name, List<Point> points) : this(points)
        {
            Name = name;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Curve"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="points">Точки.</param>
        public Curve(string name, Color color, List<Point> points) : this(name, points)
        {
            Color = color;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Curve"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="points">Точки.</param>
        /// <param name="isDirected">Логическое значение, указывающее, что направлен.</param>
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
                for (int a = 0; a < schedule.Axes.Count; ++a)
                {
                    if(a < Points[n].AxisCount)
                    {
                        points[n].Coordinates.Add(
                            schedule.Axes[a].Display(Points[n].Coordinates[a]));
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

        /// <summary>
        /// Возвращает строку представления объекта.
        /// </summary>
        /// <returns>Строка представления объекта.</returns>
        public override string ToString()
        {
            return string.Join(":", Points);
        }

        public virtual void Draw(Graphics graphics, Settings settings, int height, int width)
        {
            int middleIndex = (Points.Count - 1) / 2;
            Point middlePoint = Points.Count % 2 == 0 ? ShapeFactory.
                CreateMiddlePointByPoints(new List<Point>() { Points[middleIndex - 1],
                    Points[middleIndex + 1] }) :Points[middleIndex];
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