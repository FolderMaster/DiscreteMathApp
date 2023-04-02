using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using GraphsApp.Services.App;

namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Класс точки с координатами.
    /// </summary>
    public class Point : IShape, IComparable, IDrawable
    {
        public string Name { get; set; } = "";

        public Color Color { get; set; } = Color.White;

        /// <summary>
        /// Возвращает и задаёт координаты.
        /// </summary>
        public List<double> Coordinates { get; set; } = new List<double>();

        /// <summary>
        /// Возвращает количество осей.
        /// </summary>
        public int AxisCount
        {
            get => Coordinates.Count;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/> по умолчанию.
        /// </summary>
        public Point() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/>.
        /// </summary>
        /// <param name="coordinates">Координаты.</param>
        public Point(IEnumerable<double> coordinates)
        {
            Coordinates = coordinates.ToList();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="coordinates">Координаты.</param>
        public Point(string name, IEnumerable<double> coordinates) : this(coordinates)
        {
            Name = name;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="coordinates">Координаты.</param>
        public Point(string name, Color color, IEnumerable<double> coordinates) : this(name,
            coordinates)
        {
            Color = color;
        }

        /// <summary>
        /// Возвращает и задаёт координату по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Координата по индексу.</returns>
        public double this[int index]
        {
            get => Coordinates[index];
            set => Coordinates[index] = value;
        }

        /// <summary>
        /// Рассчитывает расстояние между точками.
        /// </summary>
        /// <param name="point">Точка.</param>
        /// <param name="plot">График.</param>
        /// <returns>Расстояние между точками.</returns>
        public double GetDistance(Point point, IPlot plot)
        {
            double result = 0;
            for (int n = 0; n < point.Coordinates.Count || n < Coordinates.Count; ++n)
            {
                double coordinate1 = n < Coordinates.Count ? Coordinates[n] :
                    plot.DefaultValue;
                double coordinate2 = n < point.Coordinates.Count ? point.Coordinates[n] :
                    plot.DefaultValue;

                result += Math.Pow(coordinate2 - coordinate1, 2);
            }
            return Math.Sqrt(result);
        }

        public IShape Display(IPlot plot)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < plot.Axes.Count; ++n)
            {
                if (n < Coordinates.Count)
                {
                    coordinates.Add(plot.Axes[n].Display(Coordinates[n]));
                }
                else
                {
                    coordinates.Add(plot.DefaultValue);
                }
            }
            return new Point(Name, Color, coordinates);
        }

        public double GetMax(IPlot plot, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : plot.DefaultValue;
        }

        public double GetMin(IPlot plot, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : plot.DefaultValue;
        }

        /// <summary>
        /// Возвращает строку представления объекта.
        /// </summary>
        /// <returns>Строка представления объекта.</returns>
        public override string ToString()
        {
            return string.Join(";", Coordinates);
        }


        /// <summary>
        /// Сравнивает точки между собой.
        /// </summary>
        /// <param name="obj">Точка.</param>
        /// <returns>Если равно 0, то точки равны, а, если меньше нуля, то эта точка меньше другой,
        /// а иначе больше.</returns>
        /// <exception cref="ArgumentException"></exception>
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