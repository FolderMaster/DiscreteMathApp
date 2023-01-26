using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
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

        public Session()
        {
        }

        public Session(SaveFormat save)
        {
            Graph.AdjacencyMatrix = save.AdjacencyMatrix;
            AdjacencyMatrixControlSession = save.AdjacencyMatrixControlSession;
            IncidenceMatrixControlSession = save.IncidenceMatrixControlSession;
        }
    }
}