using System.Collections.Generic;
using System.Drawing;

namespace GraphsApp.Views.Controls.Classes
{
    /// <summary>
    /// Класс сессии элемента управления раскраски графа с цветами.
    /// </summary>
    public class ColorGraphControlSession
    {
        /// <summary>
        /// Возвращает и задаёт цвета.
        /// </summary>
        public List<Color> Colors { get; set; } = new List<Color>();
    }
}