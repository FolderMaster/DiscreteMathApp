using System.Drawing;

namespace GraphsApp.Models.Graphs
{
    public class Edge
    {
        public string Name { get; set; } = "";

        public Vertex Begin { get; set; } = null;

        public Vertex End { get; set; } = null;

        public double Weight { get; set; } = 1;

        public bool isOutlined { get; set; } = false;

        public Edge()
        {
        }

        public Edge(string name)
        {
            Name = name;
        }

        public Edge(Vertex begin, Vertex end)
        {
            Begin = begin;
            End = end;
        }

        public Edge(string name, Vertex begin, Vertex end)
        {
            Name = name;
            Begin = begin;
            End = end;
        }

        public override string ToString()
        {
            return $"Edge '{Name}'";
        }
    }
}