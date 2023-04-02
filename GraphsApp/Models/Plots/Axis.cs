namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Класс оси, включающее масштабирование, минимальное, максимальное значения, длину,
    /// предикаты, воздействующие на минимальное и максимальное значения.
    /// </summary>
    public class Axis
    {
        public delegate double Function(double a);

        /// <summary>
        /// Возвращает и задаёт масштабирование.
        /// </summary>
        public IScale Scale { get; set; } = new LinearScale();

        /// <summary>
        /// Возвращает и задаёт минимальное значение.
        /// </summary>
        public double Min { get; set; } = 0;

        /// <summary>
        /// Возвращает и задаёт максимальное значение.
        /// </summary>
        public double Max { get; set; } = 0;

        /// <summary>
        /// Возвращает и задаёт длину.
        /// </summary>
        public double Length { get; set; } = 0;

        /// <summary>
        /// Возвращает и задаёт предикат, воздействующий на минимальное значение.
        /// </summary>
        public Function MinFunction { get; set; } = (a) => a;

        /// <summary>
        /// Возвращает и задаёт предикат, воздействующий на максимальное значение.
        /// </summary>
        public Function MaxFunction { get; set; } = (a) => a;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/> по умолчанию.
        /// </summary>
        public Axis() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/>.
        /// </summary>
        /// <param name="length">Длина.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        public Axis(double length = 0, double min = 0, double max = 0)
        {
            Length = length;
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/>.
        /// </summary>
        /// <param name="scale">Масштабирование.</param>
        /// <param name="length">Длина.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        public Axis(IScale scale, double length = 0, double min = 0, double max = 0)
        {
            Scale = scale;
            Length = length;
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/>.
        /// </summary>
        /// <param name="scale">Масштабирование.</param>
        /// <param name="minFunction">Предикат, воздействующий на минимальное значение.</param>
        /// <param name="maxFunction">предикат, воздействующий на максимальное значение.</param>
        /// <param name="length">Длина.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        public Axis(IScale scale, Function minFunction, Function maxFunction, double length = 0,
            double min = 0, double max = 0)
        {
            Scale = scale;
            Length = length;
            Min = min;
            Max = max;
            MinFunction = minFunction;
            MaxFunction = maxFunction;
        }

        /// <summary>
        /// Отображает значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Значение отображения.</returns>
        public double Display(double value)
        {
            return Scale.Display(value, Min, Max, Length);
        }
    }
}