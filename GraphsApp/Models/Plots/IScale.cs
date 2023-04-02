namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Интерфейс масштабирования с методом отображения.
    /// </summary>
    public interface IScale
    {
        /// <summary>
        /// Отображает значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="length">Длина.</param>
        /// <returns>Отображение значения.</returns>
        double Display(double value, double min, double max, double length);
    }
}