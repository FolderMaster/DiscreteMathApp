using System;
using System.Collections.Generic;
using System.Linq;

using GraphsApp.Services.Validatories;

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
                    for(int x = y; x < count; ++x)
                    {
                        result[y, x] = Vertices[y].Edges.Where((e) => e.End == Vertices[x]).
                            Count();
                        result[x, y] = result[y, x];
                    }
                }
                return result;
            }
            set
            {
                ValueValidator.AssertMatrixIsAdjacency(value, nameof(AdjacencyMatrix));

                int verticesCount = value.GetLength(0);
                Vertices.Clear();
                for (int n = 0; n < verticesCount; n++)
                {
                    Vertices.Add(new Vertex($"{n + 1}"));
                }

                Edges.Clear();
                int edgesCount = 0;
                for (int y = 0; y < verticesCount; ++y)
                {
                    for (int x = y; x < verticesCount; ++x)
                    {
                        for (int k = 0; k < value[x, y]; ++k)
                        {
                            ConnectVertexToVertex(Vertices[y], Vertices[x], Convert.ToChar('a' + 
                                edgesCount).ToString());
                            ++edgesCount;
                        }
                    }
                }
            }
        }

        public int[,] IncidenceMatrix
        {
            get
            {
                int vertexCount = Vertices.Count;
                int edgeCount = Edges.Count;
                int[,] result = new int[vertexCount, edgeCount];
                for (int x = 0; x < edgeCount; ++x)
                {
                    int y1 = Vertices.IndexOf(Edges[x].Begin);
                    int y2 = Vertices.IndexOf(Edges[x].End);
                    result[y1, x] += 1;
                    result[y2, x] += 1;
                }
                return result;
            }
            set
            {
                int verticesCount = value.GetLength(0);
                Vertices.Clear();
                for (int n = 0; n < verticesCount; n++)
                {
                    Vertices.Add(new Vertex($"{n + 1}"));
                }

                int edgesCount = value.GetLength(1);
                Edges.Clear();
                for (int x = 0; x < edgesCount; ++x)
                {
                    bool isY1Empty = true;
                    int y1 = -1;
                    int y2 = -1;
                    for(int y = 0; y < verticesCount; ++y)
                    {
                        if (value[y, x] == 2)
                        {
                            y1 = y2 = y;
                            break;
                        }
                        else if (value[y, x] == 1)
                        {
                            if(isY1Empty)
                            {
                                y1 = y;
                                isY1Empty = false;
                            }
                            else
                            {
                                y2 = y;
                                break;
                            }
                        }
                    }
                    ConnectVertexToVertex(Vertices[y1], Vertices[y2], Convert.ToChar('a' + x).ToString());
                }
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

        public void ConnectVertices(Vertex vertex1, Vertex vertex2, string name)
        {
            Edge edge = new Edge(name, vertex1, vertex2);
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