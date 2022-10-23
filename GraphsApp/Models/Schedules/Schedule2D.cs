using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GraphsApp.Models.Schedules
{
    public class Schedule2D : ISchedule
    {
        private const int count = 2;

        private Axis[] _axises = new Axis[count];

        public List<Axis> Axises
        {
            get => _axises.ToList();
        }

        public List<Axis> Axises2D
        {
            get => _axises.ToList();
            set
            {
                if (value.Count != count)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _axises = value.ToArray();
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

        public Schedule2D()
        {
        }

        public Schedule2D(List<Axis> axises2D, double defaultValue = 0)
        {
            Axises2D = axises2D;
            DefaultValue = defaultValue;
        }

        public double GetMin(int axisesIndex)
        {
            if (axisesIndex >= Axises2D.Count)
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
                        coordinates.Add(shape.GetMin(this, axisesIndex));
                    }
                    return coordinates.Min();
                }
            }
        }

        public double GetMax(int axisesIndex)
        {
            if (axisesIndex >= Axises2D.Count)
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
                        coordinates.Add(shape.GetMax(this, axisesIndex));
                    }
                    return coordinates.Max();
                }
            }
        }

        public void DefaultDisplay()
        {
            for (int n = 0; n < Axises2D.Count; ++n)
            {
                Axis axis = Axises2D[n];

                axis.Max = GetMax(n);
                axis.Max = axis.MaxFunction(axis.Max);

                axis.Min = GetMin(n);
                axis.Min = axis.MinFunction(axis.Min);
            }
        }
    }
}