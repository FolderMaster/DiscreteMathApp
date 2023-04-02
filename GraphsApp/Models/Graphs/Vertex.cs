using System.Collections.Generic;
using System.Drawing;

namespace GraphsApp.Models.Graphs
{
    /// <summary>
    /// Класс вершины с названием, цветом и списком рёбер.
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// Возвращает и задаёт название.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Возвращает и задаёт цвет.
        /// </summary>
        public Color Color { get; set; } = Color.White;

        /// <summary>
        /// Возвращает и задаёт список рёбер.
        /// </summary>
        public List<Edge> Edges { get; set; } = new List<Edge>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Vertex"/> по умолчанию.
        /// </summary>
        public Vertex() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Vertex"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        public Vertex(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Vertex"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="edges">Список рёбер.</param>
        public Vertex(string name, List<Edge> edges)
        {
            Name = name;
            Edges = edges;
        }

        /// <summary>
        /// Возвращает строку представления объекта.
        /// </summary>
        /// <returns>Строка представления объекта.</returns>
        public override string ToString() => $"Vertex '{Name}'";
    }
}