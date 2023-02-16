using System;
using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class AdjacencyMatrixControl : MatrixControl
    {
        private Graph _graph = new Graph();

        private int[,] AdjacencyMatrix
        {
            get => AdjacencyMatrixGridControl.AdjacencyMatrix;
            set => AdjacencyMatrixGridControl.AdjacencyMatrix = value;
        }

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

        public event EventHandler MatrixChanged;

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
                Session.EdgesCount, Session.LoopsCount, Session.EdgeMultiplicity);
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