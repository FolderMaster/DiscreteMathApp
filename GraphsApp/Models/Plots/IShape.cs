using System.Drawing;

namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Интерфейс фигуры с названием, цветом, методами нахождения минимального и максимального значения по оси и .
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Возвращает и задаёт название.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт цвет.
        /// </summary>
        Color Color { get; set; }

        /// <summary>
        /// Отображает фигуру на графике.
        /// </summary>
        /// <param name="plot">График.</param>
        /// <returns>Отображение фигуры.</returns>
        IShape Display(IPlot plot);

        /// <summary>
        /// Находит максимальное значение по оси.
        /// </summary>
        /// <param name="plot">График.</param>
        /// <param name="axisIndex">Индекс оси.</param>
        /// <returns>Максимальное значение по оси.</returns>
        double GetMax(IPlot plot, int axisIndex);

        /// <summary>
        /// Находит минимальное значение по оси.
        /// </summary>
        /// <param name="plot">График.</param>
        /// <param name="axisIndex">Индекс оси.</param>
        /// <returns>Минимальное значение по оси.</returns>
        double GetMin(IPlot plot, int axisIndex);
    }
}