using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Views.Controls;

namespace GraphsApp.Views.Tabs
{
    public partial class AdjacencyMatrixTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] AdjacencyMatrix
        {
            get => AdjacencyMatrixControl.AdjacencyMatrix;
            set => AdjacencyMatrixControl.AdjacencyMatrix = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => AdjacencyMatrixControl.Graph;
            set => AdjacencyMatrixControl.Graph = value;
        }

        public event EventHandler MatrixChanged;

        public AdjacencyMatrixTab()
        {
            InitializeComponent();
        }

        private void AdjacencyMatrixControl_MatrixChanged(object sender, EventArgs e)
        {
            Schedule2DControl.Graph = AdjacencyMatrixControl.Graph;
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            Schedule2DControl.Graph = AdjacencyMatrixControl.Graph;
        }
    }
}