using System;
using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    /// <summary>
    /// Элемент управления для работы с матрицей смежности.
    /// </summary>
    public partial class AdjacencyMatrixControl : MatrixControl
    {
        /// <summary>
        /// Граф.
        /// </summary>
        private Graph _graph = new Graph();

        /// <summary>
        /// Возвращает и задаёт матрица смежности.
        /// </summary>
        private int[,] AdjacencyMatrix
        {
            get => AdjacencyMatrixGridControl.AdjacencyMatrix;
            set => AdjacencyMatrixGridControl.AdjacencyMatrix = value;
        }

        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set
            {
                _graph = value;
                AdjacencyMatrix = _graph.AdjacencyMatrix;
                IsResetButtonEnable = false;
                IsSetButtonEnable = false;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик события изменения матрицы.
        /// </summary>
        public event EventHandler MatrixChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AdjacencyMatrixControl"/> по умолчанию.
        /// </summary>
        public AdjacencyMatrixControl()
        {
            InitializeComponent();
        }

        protected override void FillButtonClick()
        {
            AdjacencyMatrix = MatrixFactory.CreateAdjacencyMatrix(Session.VerticesCount,
                Session.EdgesCount);
        }

        protected override void GenerationButtonClick()
        {
            AdjacencyMatrix = MatrixFactory.CreateAdjacencyMatrix(Session.VerticesCount, 
                Session.EdgesCount, Session.LoopsCount, Session.EdgeMultiplicity,
                Session.AreOrientedConnections);
        }

        protected override void SetButtonClick()
        {
            Graph.AdjacencyMatrix = AdjacencyMatrix;
            IsResetButtonEnable = false;
            IsSetButtonEnable = false;
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override void ResetButtonClick()
        {
            AdjacencyMatrix = Graph.AdjacencyMatrix;
            IsResetButtonEnable = false;
            IsSetButtonEnable = false;
        }

        public void RefreshData()
        {
            AdjacencyMatrix = Graph.AdjacencyMatrix;
            IsResetButtonEnable = false;
            IsSetButtonEnable = false;
        }

        private void AdjacencyMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            IsResetButtonEnable = true;
            IsSetButtonEnable = true;
        }
    }
}