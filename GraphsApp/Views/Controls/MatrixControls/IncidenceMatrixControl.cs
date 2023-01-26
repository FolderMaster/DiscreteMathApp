using System;
using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class IncidenceMatrixControl : MatrixControl
    {
        private Graph _graph = new Graph();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set
            {
                _graph = value;
                IncidenceMatrixGridControl.Graph = value;
            }
        }

        public event EventHandler MatrixChanged;

        public IncidenceMatrixControl()
        {
            InitializeComponent();
        }

        protected override void FillButtonClick()
        {
            IncidenceMatrixGridControl.IncidenceMatrix = MatrixFactory.CreateIncidentMatrix
                (Session.VerticesCount, Session.EdgesCount);
        }

        protected override void GenerationButtonClick()
        {
            IncidenceMatrixGridControl.IncidenceMatrix = MatrixFactory.CreateIncidentMatrix
                (Session.VerticesCount, Session.EdgesCount, Session.LoopsCount,
                Session.EdgeMultiplicity);
        }

        public void RefreshData()
        {
            IncidenceMatrixGridControl.IncidenceMatrix = Graph.IncidenceMatrix;
        }

        private void IncidenceMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            Graph.IncidenceMatrix = IncidenceMatrixGridControl.IncidenceMatrix;
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
