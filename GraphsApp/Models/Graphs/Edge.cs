namespace GraphsApp.Models.Graphs
{
    /// <summary>
    /// Класс ребра с названием, вершины начала, конца, весом и логическим значением, указывающим
    /// на выделение.
    /// </summary>
    public class Edge   
    {
        /// <summary>
        /// Возвращает и задаёт название.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Возвращает и задаёт вершину начала.
        /// </summary>
        public Vertex Begin { get; set; } = null;

        /// <summary>
        /// Возвращает и задаёт вершину конца.
        /// </summary>
        public Vertex End { get; set; } = null;

        /// <summary>
        /// Возвращает и задаёт вес.
        /// </summary>
        public double Weight { get; set; } = 1;

        /// <summary>
        /// Возвращает и задаёт логическое значение, указывающее на выделение.
        /// </summary>
        public bool IsOutlined { get; set; } = false;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Edge"/> по умолчанию.
        /// </summary>
        public Edge() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Edge"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="begin">Вершина начала.</param>
        /// <param name="end">Вершина конца.</param>
        public Edge(string name, Vertex begin, Vertex end)
        {
            Name = name;
            Begin = begin;
            End = end;
        }

        /// <summary>
        /// Возвращает строку представления объекта.
        /// </summary>
        /// <returns>Строка представления объекта.</returns>
        public override string ToString() => $"Edge '{Name}'";
    }
}