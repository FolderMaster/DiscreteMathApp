using GraphsApp.Models.Graphs;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Services.App
{
    public class Session
    {
        public Graph Graph { get; set; } = new Graph();

        public MatrixControlSession AdjacencyMatrixControlSession { get; set; } = new
            MatrixControlSession();

        public MatrixControlSession IncidenceMatrixControlSession { get; set; } = new
            MatrixControlSession();

        public ColorGraphControlSession ColorGraphControlSession { get; set; } = new 
            ColorGraphControlSession();

        public Session()
        {
        }

        public Session(SaveFormat save)
        {
            Graph = save.Graph;
            AdjacencyMatrixControlSession = save.AdjacencyMatrixControlSession;
            IncidenceMatrixControlSession = save.IncidenceMatrixControlSession;
            ColorGraphControlSession= save.ColorGraphControlSession;
        }
    }
}