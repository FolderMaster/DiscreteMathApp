using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Controls
{
    public partial class AdjacencyMatrixControl : UserControl
    {
        private int _verticesCount = 0;

        private int _edgeMultiplicity = 0;

        private int _loopsCount = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] AdjacencyMatrix
        {
            get => AdjacencyMatrixGridControl.AdjacencyMatrix;
            set => AdjacencyMatrixGridControl.AdjacencyMatrix = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => AdjacencyMatrixGridControl.Graph;
            set => AdjacencyMatrixGridControl.Graph = value;
        }

        public event EventHandler MatrixChanged;

        public AdjacencyMatrixControl()
        {
            InitializeComponent();
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            AdjacencyMatrix = MatrixFactory.CreateAdjacencyMatrix(_verticesCount, _loopsCount, 
                _edgeMultiplicity);
        }

        private void VerticesCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _verticesCount = (int)VerticesCountNumericUpDown.Value;
        }

        private void EdgeMultiplicityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _edgeMultiplicity = (int)EdgeMultiplicityNumericUpDown.Value;
        }

        private void LoopsCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _loopsCount = (int)LoopsCountNumericUpDown.Value;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            AdjacencyMatrix = MatrixFactory.CreateAdjacencyMatrix(_verticesCount);
        }

        private void AdjacencyMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}