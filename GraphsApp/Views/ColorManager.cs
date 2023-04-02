using System.Drawing;

namespace GraphsApp.Views
{
    /// <summary>
    /// Класс менеджера цветов с цветами.
    /// </summary>
    public static class ColorManager
    {
        /// <summary>
        /// Возвращает цвет корректной работы.
        /// </summary>
        public static Color CorrectColor { get; } = Color.White;

        /// <summary>
        /// Возвращает цвет ошибки.
        /// </summary>
        public static Color ErrorColor { get; } = Color.Pink;
    }
}