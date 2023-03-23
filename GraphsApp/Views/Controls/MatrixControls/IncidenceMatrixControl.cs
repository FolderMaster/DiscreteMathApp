using System;
using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class IncidenceMatrixControl : MatrixControl
    {
        private Graph _graph = new Graph();

        private int[,] IncidenceMatrix
        {
            get => IncidenceMatrixGridControl.IncidenceMatrix;
            set => IncidenceMatrixGridControl.IncidenceMatrix = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set
            {
                _graph = value;
                IncidenceMatrix = _graph.IncidenceMatrix;
                IsResetButtonEnable = false;
                IsSetButtonEnable = false;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler MatrixChanged;

        public IncidenceMatrixControl()
        {
            InitializeComponent();
        }

        protected override void FillButtonClick()
        {
            IncidenceMatrix = MatrixFactory.CreateIncidentMatrix(Session.VerticesCount, 
                Session.EdgesCount);
        }

        protected override void GenerationButtonClick()
        {
            IncidenceMatrix = MatrixFactory.CreateIncidentMatrix(Session.VerticesCount,
                Session.EdgesCount, Session.LoopsCount, Session.EdgeMultiplicity,
                Session.AreOrientedConnections);
        }

        protected override void SetButtonClick()
        {
            try
            {
                Graph.IncidenceMatrix = IncidenceMatrix;
                IsResetButtonEnable = false;
                IsSetButtonEnable = false;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        protected override void ResetButtonClick()
        {
            IncidenceMatrix = Graph.IncidenceMatrix;
            IsResetButtonEnable = false;
            IsSetButtonEnable = false;
        }

        public void RefreshData()
        {
            IncidenceMatrix = Graph.IncidenceMatrix;
            IsResetButtonEnable = false;
            IsSetButtonEnable = false;
        }

        private void IncidenceMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            IsResetButtonEnable = true;
            IsSetButtonEnable = true;
        }
    }
}
