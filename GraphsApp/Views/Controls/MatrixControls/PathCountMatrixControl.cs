using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Managers;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class PathCountMatrixControl : UserControl
    {
        private int _pathLength = 1;

        private Graph _graph = new Graph();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set => _graph = value;
        }

        public PathCountMatrixControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = new int[0, 0];
        }

        private void PathLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _pathLength = (int)PathLengthNumericUpDown.Value;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = MatrixManager.Pow(Graph.AdjacencyMatrix,
                _pathLength);
        }
    }
}