namespace GraphsApp.Models.Graphs
{
    public class Edge
    {
        public string Name { get; set; } = "";

        public Vertex Begin { get; set; }

        public Vertex End { get; set; }

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
    }
}