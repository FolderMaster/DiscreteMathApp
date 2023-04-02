using GraphsApp.Models.Graphs;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Services.App
{
    /// <summary>
    /// Класс формата сохранения с графом, сессиями элементов управления матриц смежности,
    /// инцидентности и раскраски графа.
    /// </summary>
    public class SaveFormat
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
        /// Создаёт экземпляр класса <see cref="SaveFormat"/> по умолчанию.
        /// </summary>
        public SaveFormat() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveFormat"/>.
        /// </summary>
        /// <param name="session">Сессия.</param>
        public SaveFormat(Session session)
        {
            Graph = session.Graph;
            AdjacencyMatrixControlSession = session.AdjacencyMatrixControlSession;
            IncidenceMatrixControlSession = session.IncidenceMatrixControlSession;
            ColorGraphControlSession = session.ColorGraphControlSession;
        }
    }
}