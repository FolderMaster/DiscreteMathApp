using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Класс двухмерного графика с двумя осями, значением по умолчанию.
    /// </summary>
    public class Plot2D : IPlot
    {
        /// <summary>
        /// Количество осей.
        /// </summary>
        private const int _axesCount = 2;

        /// <summary>
        /// Оси.
        /// </summary>
        private Axis[] _axes = new Axis[_axesCount];

        public List<Axis> Axes
        {
            get => _axes.ToList();
        }

        /// <summary>
        /// Возвращает и задаёт две оси.
        /// </summary>
        public List<Axis> Axes2D
        {
            get => _axes.ToList();
            set
            {
                if (value.Count != _axesCount)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _axes = value.ToArray();
                }
            }
        }

        public List<IShape> Shapes { get; set; } = new List<IShape>();

        public List<IShape> Displays
        {
            get
            {
                List<IShape> result = new List<IShape>();
                foreach (IShape shape in Shapes)
                {
                    result.Add(shape.Display(this));
                }
                return result;
            }
        }

        public double DefaultValue { get; set; } = 0;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Plot2D"/> по умолчанию.
        /// </summary>
        public Plot2D() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Plot2D"/>.
        /// </summary>
        /// <param name="axes2D">Две оси.</param>
        /// <param name="defaultValue">Значение по умолчанию.</param>
        public Plot2D(List<Axis> axes2D, double defaultValue = 0)
        {
            Axes2D = axes2D;
            DefaultValue = defaultValue;
        }

        public double GetMin(int axesIndex)
        {
            if (axesIndex >= Axes2D.Count)
            {
                throw new ArgumentException();
            }
            else
            {
                if (Shapes.Count == 0)
                {
                    return DefaultValue;
                }
                else
                {
                    List<double> coordinates = new List<double>();
                    foreach (IShape shape in Shapes)
                    {
                        coordinates.Add(shape.GetMin(this, axesIndex));
                    }
                    return coordinates.Min();
                }
            }
        }

        public double GetMax(int axesIndex)
        {
            if (axesIndex >= Axes2D.Count)
            {
                throw new ArgumentException();
            }
            else
            {
                if (Shapes.Count == 0)
                {
                    return DefaultValue;
                }
                else
                {
                    List<double> coordinates = new List<double>();
                    foreach (IShape shape in Shapes)
                    {
                        coordinates.Add(shape.GetMax(this, axesIndex));
                    }
                    return coordinates.Max();
                }
            }
        }

        public void DefaultDisplay()
        {
            for (int n = 0; n < Axes2D.Count; ++n)
            {
                Axis axis = Axes2D[n];

                axis.Max = GetMax(n);
                axis.Max = axis.MaxFunction(axis.Max);

                axis.Min = GetMin(n);
                axis.Min = axis.MinFunction(axis.Min);
            }
        }
    }
}