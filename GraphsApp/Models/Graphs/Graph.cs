using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphsApp.Models.Graphs
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; } = new List<Vertex>();

        public List<Edge> Edges { get; set; } = new List<Edge>();

        public int[,] AdjacencyMatrix
        {
            get
            {
                int count = Vertices.Count;
                int[,] result = new int[count, count];
                for(int y = 0; y < count; ++y)
                {
                    for(int x = 0; x < count; ++x)
                    {
                    }
                }
                return result;
            }
        }

        public Graph()
        {
        }

        public Graph(List<Vertex> vertices)
        {
            Vertices = vertices;
        }

        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            Vertices = vertices;
            Edges = edges;
        }

        public void ConnectVertices(Vertex vertex1, Vertex vertex2)
        {
            Edge edge = new Edge(vertex1, vertex2);
            vertex1.Edges.Add(edge);
            if (vertex1 != vertex2)
            {
                vertex2.Edges.Add(edge);
            }
            Edges.Add(edge);
        }
    }
}