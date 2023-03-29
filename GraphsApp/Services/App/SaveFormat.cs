using GraphsApp.Models.Graphs;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Services.App
{
    public class SaveFormat
    {
        public Graph Graph { get; set; } = new Graph();

        public MatrixControlSession AdjacencyMatrixControlSession { get; set; } = new 
            MatrixControlSession();

        public MatrixControlSession IncidenceMatrixControlSession { get; set; } = new
            MatrixControlSession();

        public ColorGraphControlSession ColorGraphControlSession { get; set; } = new
            ColorGraphControlSession();

        public SaveFormat()
        {
        }

        public SaveFormat(Session session)
        {
            Graph = session.Graph;
            AdjacencyMatrixControlSession = session.AdjacencyMatrixControlSession;
            IncidenceMatrixControlSession = session.IncidenceMatrixControlSession;
            ColorGraphControlSession = session.ColorGraphControlSession;
        }
    }
}