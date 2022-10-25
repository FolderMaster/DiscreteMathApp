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

        public int[,] IncidenceMatrix
        {
            get
            {
                int vertexCount = Vertices.Count;
                int edgeCount = Edges.Count;
                int[,] result = new int[edgeCount, vertexCount];
                for (int y = 0; y < edgeCount; ++y)
                {
                    for (int x = 0; x < vertexCount; ++x)
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
            vertex2.Edges.Add(edge);
            Edges.Add(edge);
        }

        public void ConnectVerticesByEdge(Vertex vertex1, Vertex vertex2, Edge edge)
        {
            edge.Begin = vertex1;
            edge.End = vertex2;
            vertex1.Edges.Add(edge);
            vertex2.Edges.Add(edge);
            if(!Edges.Contains(edge))
            {
                Edges.Add(edge);
            }
        }

        public void ConnectVertexToVertex(Vertex vertex1, Vertex vertex2, string name)
        {
            Edge edge = new Edge(name, vertex1, vertex2);
            vertex1.Edges.Add(edge);
            Edges.Add(edge);
        }

        public void ConnectVertexToVertexByEdge(Vertex vertex1, Vertex vertex2, Edge edge)
        {
            edge.Begin = vertex1;
            edge.End = vertex2;
            vertex1.Edges.Add(edge);
            Edges.Add(edge);
        }
    }
}