namespace GraphsApp.Models.Plots
{
    public class Axis
    {
        public delegate double Function(double a);

        public IScale Scale { get; set; } = new LinearScale();

        public double Min { get; set; } = 0;

        public double Max { get; set; } = 0;

        public double Length { get; set; } = 0;

        public Function MinFunction { get; set; } = (a) => a;

        public Function MaxFunction { get; set; } = (a) => a;

        public Axis()
        {
        }

        public Axis(double lenght = 0, double min = 0, double max = 0)
        {
            Length = lenght;
            Min = min;
            Max = max;
        }

        public Axis(IScale scale, double lenght = 0, double min = 0, double max = 0)
        {
            Scale = scale;
            Length = lenght;
            Min = min;
            Max = max;
        }

        public Axis(IScale scale, Function minFunction, Function maxFunction, double lenght = 0,
            double min = 0, double max = 0)
        {
            Scale = scale;
            Length = lenght;
            Min = min;
            Max = max;
            MinFunction = minFunction;
            MaxFunction = maxFunction;
        }

        public double Display(double value)
        {
            return Scale.Display(value, Min, Max, Length);
        }
    }
}