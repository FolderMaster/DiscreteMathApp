using System.Collections.Generic;
using System.Drawing;

namespace GraphsApp.Models.Graphs
{
    public class Vertex
    {
        public string Name { get; set; } = "";

        public Color Color { get; set; } = Color.White;

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

        public override string ToString()
        {
            return $"Vertex '{Name}'";
        }
    }
}