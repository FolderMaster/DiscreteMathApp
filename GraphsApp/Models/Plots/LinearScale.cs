namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Класс линейного масштабирование с методом отображения.
    /// </summary>
    public class LinearScale : IScale
    {
        public double Display(double value, double min, double max, double length) =>
            (value - min) / (max - min) * length;
    }
}