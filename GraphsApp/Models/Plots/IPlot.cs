using System.Collections.Generic;

namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Интерфейс графика с осями, значением по умолчанию, фигурами и их отображениями, методами
    /// расчёта максимального и минимального значений на оси, стандартного отображения.
    /// </summary>
    public interface IPlot
    {
        /// <summary>
        /// Возвращает и задаёт оси.
        /// </summary>
        List<Axis> Axes { get; }

        /// <summary>
        /// Возвращает и задаёт фигуры.
        /// </summary>
        List<IShape> Shapes { get; set; }

        /// <summary>
        /// Возвращает и задаёт отображения фигур.
        /// </summary>
        List<IShape> Displays { get; }

        /// <summary>
        /// Возвращает и задаёт значение по умолчанию.
        /// </summary>
        double DefaultValue { get; set; }

        /// <summary>
        /// Находит минимальное значение оси.
        /// </summary>
        /// <param name="axesIndex">Индекс оси.</param>
        /// <returns>Минимальное значение оси.</returns>
        double GetMin(int axesIndex);

        /// <summary>
        /// Находит максимальное значение оси.
        /// </summary>
        /// <param name="axesIndex">Индекс оси.</param>
        /// <returns>Максимальное значение оси.</returns>
        double GetMax(int axesIndex);

        /// <summary>
        /// Отображает фигуры по умолчанию.
        /// </summary>
        void DefaultDisplay();
    }
}