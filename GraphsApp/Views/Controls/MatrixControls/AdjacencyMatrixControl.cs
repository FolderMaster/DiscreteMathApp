using System;
using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class AdjacencyMatrixControl : MatrixControl
    {
        private Graph _graph = new Graph();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set
            {
                _graph = value;
                AdjacencyMatrixGridControl.Graph = value;
            }
        }

        public event EventHandler MatrixChanged;

        public AdjacencyMatrixControl()
        {
            InitializeComponent();
        }

        protected override void FillButtonClick()
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = MatrixFactory.CreateAdjacencyMatrix
                (Session.VerticesCount, Session.EdgesCount);
        }

        protected override void GenerationButtonClick()
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = MatrixFactory.CreateAdjacencyMatrix
                (Session.VerticesCount, Session.EdgesCount, Session.LoopsCount,
                Session.EdgeMultiplicity);
        }

        public void RefreshData()
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = Graph.AdjacencyMatrix;
        }

        private void AdjacencyMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            Graph.AdjacencyMatrix = AdjacencyMatrixGridControl.AdjacencyMatrix;
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}