using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Services.App
{
    public class SaveFormat
    {
        public int[,] AdjacencyMatrix { get; set; } = new int[0, 0];

        public MatrixControlSession AdjacencyMatrixControlSession { get; set; } = new 
            MatrixControlSession();

        public MatrixControlSession IncidenceMatrixControlSession { get; set; } = new
            MatrixControlSession();

        public SaveFormat()
        {
        }

        public SaveFormat(Session session)
        {
            AdjacencyMatrix = session.Graph.AdjacencyMatrix;
            AdjacencyMatrixControlSession = session.AdjacencyMatrixControlSession;
            IncidenceMatrixControlSession = session.IncidenceMatrixControlSession;
        }
    }
}