namespace GraphsApp.Views.Controls.Classes
{
    /// <summary>
    /// Класс сессии элемента управления матрицы.
    /// </summary>
    public class MatrixControlSession
    {
        /// <summary>
        /// Возвращает и задаёт количество вершин.
        /// </summary>
        public int VerticesCount { get; set; } = 0;

        /// <summary>
        /// Возвращает и задаёт количество рёбер.
        /// </summary>
        public int EdgesCount { get; set; } = 0;

        /// <summary>
        /// Возвращает и задаёт максимальное количество рёбер у вершины.
        /// </summary>
        public int EdgeMultiplicity { get; set; } = 0;

        /// <summary>
        /// Возвращает и задаёт количество петлей.
        /// </summary>
        public int LoopsCount { get ; set; } = 0;

        /// <summary>
        /// Возвращает и задаёт Логическое значение, указывающее, что матрица ориентирована.
        /// </summary>
        public bool AreOrientedConnections { get; set; } = false;
    }
}