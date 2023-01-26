using System.Linq;
using System.Drawing;

namespace GraphsApp.Models.Schedules
{
    public class Curve : IShape
    {
        public string Name { get; set; } = "";

        public Color Color { get; set; } = Color.Black;

        public Point Begin { get; set; } = new Point();

        public Point Middle { get; set; } = new Point();

        public Point End { get; set; } = new Point();

        public Curve()
        {
        }

        public Curve(Point begin, Point middle, Point end)
        {
            Begin = begin;
            Middle = middle;
            End = end;
        }

        public Curve(string name, Point begin, Point middle, Point end)
        {
            Name = name;
            Begin = begin;
            Middle = middle;
            End = end;
        }

        public Curve(string name, Color color, Point begin, Point middle, Point end)
        {
            Name = name;
            Color = color;
            Begin = begin;
            Middle = middle;
            End = end;
        }

        public IShape Display(ISchedule schedule)
        {
            Point begin = new Point();
            Point middle = new Point();
            Point end = new Point();

            for (int n = 0; n < schedule.Axises.Count; ++n)
            {
                if (n < Begin.Coordinates.Count)
                {
                    begin.Coordinates.Add(schedule.Axises[n].Display(Begin.Coordinates[n]));
                }
                else
                {
                    begin.Coordinates.Add(schedule.DefaultValue);
                }

                if (n < Middle.Coordinates.Count)
                {
                    middle.Coordinates.Add(schedule.Axises[n].Display(Middle.Coordinates[n]));
                }
                else
                {
                    middle.Coordinates.Add(schedule.DefaultValue);
                }

                if (n < End.Coordinates.Count)
                {
                    end.Coordinates.Add(schedule.Axises[n].Display(End.Coordinates[n]));
                }
                else
                {
                    end.Coordinates.Add(schedule.DefaultValue);
                }
            }
            return new Curve(Name, Color, begin, middle, end);
        }

        public double GetMax(ISchedule schedule, int axisIndex)
        {
            double[] values = new double[3]
            {
                axisIndex < Begin.Coordinates.Count ? Begin.Coordinates[axisIndex] : 
                schedule.DefaultValue,
                axisIndex < Middle.Coordinates.Count ? Middle.Coordinates[axisIndex] : 
                schedule.DefaultValue,
                axisIndex < End.Coordinates.Count ? End.Coordinates[axisIndex] : 
                schedule.DefaultValue
            };
            return values.Max();
        }

        public double GetMin(ISchedule schedule, int axisIndex)
        {
            double[] values = new double[3]
            {
                axisIndex < Begin.Coordinates.Count ? Begin.Coordinates[axisIndex] :
                schedule.DefaultValue,
                axisIndex < Middle.Coordinates.Count ? Middle.Coordinates[axisIndex] :
                schedule.DefaultValue,
                axisIndex < End.Coordinates.Count ? End.Coordinates[axisIndex] :
                schedule.DefaultValue
            };
            return values.Min();
        }

        public override string ToString()
        {
            return $"{Begin}\t{Middle}\t{End}";
        }
    }
}