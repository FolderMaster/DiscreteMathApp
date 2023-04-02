using GraphsApp.Models.Graphs;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Services.App
{
    /// <summary>
    /// Класс сессии с графом, сессиями элементов управления матриц смежности, инцидентности и
    /// раскраски графа.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        public Graph Graph { get; set; } = new Graph();

        /// <summary>
        /// Возвращает и задаёт сессию элемента управления матрицы смежности.
        /// </summary>
        public MatrixControlSession AdjacencyMatrixControlSession { get; set; } = new
            MatrixControlSession();

        /// <summary>
        /// Возвращает и задаёт сессию элемента управления матрицы инцидентности.
        /// </summary>
        public MatrixControlSession IncidenceMatrixControlSession { get; set; } = new
            MatrixControlSession();

        /// <summary>
        /// Возвращает и задаёт сессию элемента управления раскраски графа.
        /// </summary>
        public ColorGraphControlSession ColorGraphControlSession { get; set; } = new 
            ColorGraphControlSession();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/> по умолчанию.
        /// </summary>
        public Session() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/>.
        /// </summary>
        /// <param name="save">Формат сохранения.</param>
        public Session(SaveFormat save)
        {
            Graph = save.Graph;
            AdjacencyMatrixControlSession = save.AdjacencyMatrixControlSession;
            IncidenceMatrixControlSession = save.IncidenceMatrixControlSession;
            ColorGraphControlSession= save.ColorGraphControlSession;
        }
    }
}