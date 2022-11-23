using GraphsApp.Models.Graphs;

namespace GraphsApp.Services.App
{
    public class Session
    {
        public Graph Graph { get; set; } = new Graph();

        public Session()
        {
        }

        public Session(Graph graph)
        {
            Graph = graph;
        }
    }
}