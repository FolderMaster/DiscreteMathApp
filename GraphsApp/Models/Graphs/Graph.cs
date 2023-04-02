using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using GraphsApp.Services.Validators;

namespace GraphsApp.Models.Graphs
{
    /// <summary>
    /// Класс графа со списками вершин и рёбер, матрицами смежности и инцидентности, логическим
    /// значением, указывающим на ориентированность.
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Логическое значение, указывающее на ориентированность.
        /// </summary>
        private bool _isOriented = false;

        /// <summary>
        /// Возвращает и задаёт логическое значение, указывающее на ориентированность.
        /// </summary>
        public bool IsOriented
        {
            get => _isOriented;
            private set => _isOriented = value;
        }

        /// <summary>
        /// Возвращает и задаёт список вершин.
        /// </summary>
        public List<Vertex> Vertices { get; set; } = new List<Vertex>();

        /// <summary>
        /// Возвращает и задаёт список рёбер.
        /// </summary>
        public List<Edge> Edges { get; set; } = new List<Edge>();

        /// <summary>
        /// Возвращает и задаёт матрицу смежности. Должна удовлетворять условиям сложности.
        /// </summary>
        [JsonIgnore]
        public int[,] AdjacencyMatrix
        {
            get
            {
                int verticesCount = Vertices.Count;
                int[,] result = new int[verticesCount, verticesCount];
                for(int y = 0; y < verticesCount; ++y)
                {
                    for(int x = 0; x < verticesCount; ++x)
                    {
                        int count;
                        if (x != y)
                        {
                            count = Vertices[y].Edges.Where((edge) => edge.End == Vertices[x] ||
                            edge.Begin == Vertices[x]).Count();
                        }
                        else
                        {
                            count = Vertices[y].Edges.Where((edge) =>
                            edge.End == edge.Begin).Count();
                        }
                        result[y, x] = count;
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
                    Vertices.Add(new Vertex(GetNameForVertex(n)));
                }
                Edges.Clear();
                IsOriented = false;

                int edgesCount = 0;
                for (int y = 0; y < verticesCount; ++y)
                {
                    for (int x = y; x < verticesCount; ++x)
                    {

                        if(value[x, y] == value[y, x])
                        {
                            for (int k = 0; k < value[y, x]; ++k)
                            {
                                ConnectVertices(Vertices[y], Vertices[x],
                                    GetNameForEdge(edgesCount));
                                ++edgesCount;
                            }
                        }
                        else
                        {
                            IsOriented = true;
                            for (int k = 0; k < value[y, x]; ++k)
                            {
                                ConnectVertexToVertex(Vertices[y], Vertices[x],
                                    GetNameForEdge(edgesCount));
                                ++edgesCount;
                            }
                            for (int k = 0; k < value[x, y]; ++k)
                            {
                                ConnectVertexToVertex(Vertices[x], Vertices[y],
                                    GetNameForEdge(edgesCount));
                                ++edgesCount;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт матрицу инцидентности. Должна удовлетворять условиям инцидентности.
        /// </summary>
        [JsonIgnore]
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
                    if (Vertices[y1].Edges.Contains(Edges[x]) &&
                        Vertices[y2].Edges.Contains(Edges[x]))
                    {
                        result[y1, x] += 1;
                        result[y2, x] += 1;
                    }
                    else
                    {
                        if(Vertices[y1].Edges.Contains(Edges[x]))
                        {
                            result[y1, x] = -1;
                            result[y2, x] = 1;
                        }
                        else
                        {
                            result[y1, x] = 1;
                            result[y2, x] = -1;
                        }
                    }
                }
                return result;
            }
            set
            {
                ValueValidator.AssertMatrixIsIncidence(value, nameof(IncidenceMatrix));

                int verticesCount = value.GetLength(0);
                Vertices.Clear();
                for (int n = 0; n < verticesCount; n++)
                {
                    Vertices.Add(new Vertex(GetNameForVertex(n)));
                }
                int edgesCount = value.GetLength(1);
                Edges.Clear();
                IsOriented = false;

                for (int x = 0; x < edgesCount; ++x)
                {
                    bool isOriented = false;
                    Vertex vertex1 = null;
                    Vertex vertex2 = null;
                    for(int y = 0; y < verticesCount; ++y)
                    {
                        if (value[y, x] == 2)
                        {
                            vertex1 = vertex2 = Vertices[y];
                            isOriented = false;
                            break;
                        }
                        else if (value[y, x] == 1)
                        {
                            if(vertex1 == null)
                            {
                                vertex1 = Vertices[y];
                            }
                            else
                            {
                                vertex2 = Vertices[y];
                                isOriented = false;
                                break;
                            }
                        }
                        else if (value[y, x] == -1)
                        {
                            if (vertex1 == null)
                            {
                                vertex1 = Vertices[y];
                            }
                            else
                            {
                                vertex2 = vertex1;
                                vertex1 = Vertices[y];
                                isOriented = true;
                                break;
                            }
                        }
                    }
                    if(vertex1 != null && vertex2 != null)
                    {
                        if(isOriented)
                        {
                            ConnectVertexToVertex(vertex1, vertex2, GetNameForEdge(x));
                            IsOriented = true;
                        }
                        else
                        {
                            ConnectVertices(vertex1, vertex2, GetNameForEdge(x));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Graph"/> по умолчанию.
        /// </summary>
        public Graph() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Graph"/>.
        /// </summary>
        /// <param name="vertices">Список вершин.</param>
        /// <param name="edges">Список рёбер.</param>
        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            Vertices = vertices;
            Edges = edges;
        }

        /// <summary>
        /// Соединяет вершины.
        /// </summary>
        /// <param name="vertex1">Вершина 1.</param>
        /// <param name="vertex2">Вершина 2.</param>
        /// <param name="name">Название для ребра.</param>
        private void ConnectVertices(Vertex vertex1, Vertex vertex2, string name)
        {
            Edge edge = new Edge(name, vertex1, vertex2);
            vertex1.Edges.Add(edge);
            if(vertex1 != vertex2)
            {
                vertex2.Edges.Add(edge);
            }
            Edges.Add(edge);
        }

        /// <summary>
        /// Соединяет вершину к вершине.
        /// </summary>
        /// <param name="vertex1">Вершина 1.</param>
        /// <param name="vertex2">Вершина 2.</param>
        /// <param name="name">Название для ребра.</param>
        private void ConnectVertexToVertex(Vertex vertex1, Vertex vertex2, string name)
        {
            Edge edge = new Edge(name, vertex1, vertex2);
            vertex1.Edges.Add(edge);
            Edges.Add(edge);
        }

        /// <summary>
        /// Возвращает название для ребра.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название для ребра.</returns>
        private string GetNameForEdge(int index) => Convert.ToChar('a' + index).ToString();

        /// <summary>
        /// Возвращает название для вершины.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название для вершины.</returns>
        private string GetNameForVertex(int index) => $"{index + 1}";
    }
}