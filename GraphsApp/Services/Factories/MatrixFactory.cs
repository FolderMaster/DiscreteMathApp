using System;
using System.Collections.Generic;

namespace GraphsApp.Services.Factories
{
    /// <summary>
    /// Класс фабрики матриц с методами создания матриц.
    /// </summary>
    public static class MatrixFactory
    {
        /// <summary>
        /// Создаёт матрицу смежности.
        /// </summary>
        /// <param name="verticesCount">Количество вершин.</param>
        /// <param name="edgesCount">Количество рёбер.</param>
        /// <param name="loopsCount">Количество петлей.</param>
        /// <param name="edgeMultiplicity">Максимальное количество рёбер у вершины.</param>
        /// <param name="areOrientedConnections">Логическое значение, указывающее, что матрица
        /// ориентирована.</param>
        /// <returns>Матрица смежности.</returns>
        public static int[,] CreateAdjacencyMatrix(int verticesCount, int edgesCount, 
            int loopsCount = 0, int edgeMultiplicity = 0, bool areOrientedConnections = false)
        {
            Random random = new Random();
            int[,] result = new int[verticesCount, verticesCount];
            for(int y = 0; y < verticesCount; ++y)
            {
                for(int x = y; x < verticesCount; ++x)
                {
                    int generatedValue;
                    if (y == x)
                    {
                        generatedValue = random.Next(Math.Min(edgesCount, Math.Min(loopsCount,
                            edgeMultiplicity)) + 1);
                        result[y, x] = generatedValue;
                        loopsCount -= generatedValue;
                    }
                    else
                    {
                        generatedValue = random.Next(Math.Min(edgesCount, edgeMultiplicity) + 1);
                        if (areOrientedConnections)
                        {
                            result[x, y] = random.Next(generatedValue + 1);
                            result[y, x] = generatedValue - result[x, y];
                        }
                        else
                        {
                            result[x, y] = result[y, x] = generatedValue;
                        }
                    }
                    edgesCount -= generatedValue;
                }
            }
            return result;
        }

        /// <summary>
        /// Создаёт матрицу инцидентности.
        /// </summary>
        /// <param name="verticesCount">Количество вершин.</param>
        /// <param name="edgesCount">Количество рёбер.</param>
        /// <param name="loopsCount">Количество петлей.</param>
        /// <param name="edgeMultiplicity">Максимальное количество рёбер у вершины.</param>
        /// <param name="areOrientedConnections">Логическое значение, указывающее, что матрица
        /// ориентирована.</param>
        /// <returns>Матрица инцидентности.</returns>
        public static int[,] CreateIncidentMatrix(int verticesCount, int edgesCount,
            int loopsCount = 0, int edgeMultiplicity = 0, bool areOrientedConnections = false)
        {
            Random random = new Random();
            int[,] result = new int[verticesCount, edgesCount];
            List<(int, int, int)> verticesConnectionsCount = new List<(int, int, int)>();
            for (int y = 0; y < verticesCount; ++y)
            {
                for (int x = 0; x < verticesCount; ++x)
                {
                    if(x == y)
                    {
                        if(loopsCount > 0 && edgeMultiplicity > 0)
                        {
                            verticesConnectionsCount.Add((y, x, 0));
                        }
                    }
                    else
                    {
                        if (edgeMultiplicity > 0)
                        {
                            verticesConnectionsCount.Add((y, x, 0));
                        }
                    }
                }
            }

            for (int x = 0; x < edgesCount; ++x)
            {
                if(verticesConnectionsCount.Count == 0)
                {
                    break;
                }
                int connectionIndex = random.Next(verticesConnectionsCount.Count);
                int fromVertexIndex = verticesConnectionsCount[connectionIndex].Item1;
                int toVertexIndex = verticesConnectionsCount[connectionIndex].Item2;
                verticesConnectionsCount[connectionIndex] = (fromVertexIndex, toVertexIndex,
                    verticesConnectionsCount[connectionIndex].Item3 + 1);
                if(fromVertexIndex == toVertexIndex && verticesConnectionsCount[connectionIndex].
                    Item3 == Math.Min(edgeMultiplicity, loopsCount) || verticesConnectionsCount
                    [connectionIndex].Item3 == edgeMultiplicity)
                {
                    verticesConnectionsCount.RemoveAt(connectionIndex);
                }

                if (toVertexIndex == fromVertexIndex)
                {
                    result[toVertexIndex, x] = 2;
                }
                else
                {
                    if (!areOrientedConnections)
                    {
                        result[fromVertexIndex, x] = result[toVertexIndex, x] = 1;
                    }
                    else
                    {
                        result[fromVertexIndex, x] = -1;
                        result[toVertexIndex, x] = 1;
                    }
                }
            }
            return result;
        }
    }
}