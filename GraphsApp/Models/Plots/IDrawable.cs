using System.Drawing;

using GraphsApp.Services.App;

namespace GraphsApp.Models.Plots
{
    /// <summary>
    /// Интерфейс изображения информации, который предоставляет соответствующий метод.
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Изображает информацию.
        /// </summary>
        /// <param name="graphics">Объект графики.</param>
        /// <param name="settings">Настройки.</param>
        /// <param name="height">Высота.</param>
        /// <param name="width">Ширина.</param>
        void Draw(Graphics graphics, Settings settings, int height, int width);
    }
}