using System.Drawing;

namespace GraphsApp.Services.App
{
    /// <summary>
    /// Класс настроек с путём сохранения и свойствами отображения.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Возвращает и задаёт путь сохранения.
        /// </summary>
        public string SavePath { get; set; } = "Save.txt";

        /// <summary>
        /// Возвращает и задаёт шрифт значений.
        /// </summary>
        public Font ValueFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10,
            FontStyle.Regular);

        /// <summary>
        /// Возвращает и задаёт ширину стрелки указателя.
        /// </summary>
        public int ArrowCapWidth { get; set; } = 5;

        /// <summary>
        /// Возвращает и задаёт высоту стрелки указателя.
        /// </summary>
        public int ArrowCapHeight { get; set; } = 5;

        /// <summary>
        /// Возвращает и задаёт 
        /// </summary>
        public SolidBrush FontSolidBrush { get; set; } = new SolidBrush(Color.Red);

        /// <summary>
        /// Возвращает и задаёт размер точки.
        /// </summary>
        public int PointSize { get; set; } = 10;

        /// <summary>
        /// Возвращает и задаёт ручку внешних границ точки.
        /// </summary>
        public Pen OuterPointPen { get; set; } = new Pen(Color.Black);

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Settings"/> по умолчанию.
        /// </summary>
        public Settings() {}
    }
}