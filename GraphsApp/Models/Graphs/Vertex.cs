using System.Collections.Generic;

namespace GraphsApp.Models.Graphs
{
    public class Vertex
    {
        public string Name { get; set; } = "";

        public List<Edge> Edges { get; set; } = new List<Edge>();

        public Vertex()
        {
        }

        public Vertex(string name)
        {
            Name = name;
        }

        public Vertex(string name, List<Edge> edges)
        {
            Name = name;
            Edges = edges;
        }
    }
}