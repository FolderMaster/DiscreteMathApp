using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Services.Managers;
using GraphsApp.Services.Validatories;

namespace GraphsApp.Views.Controls
{
    public partial class PathMatrixControl : UserControl
    {
        private int _pathLength = 1;

        private int[,] _adjacencyMatrix = new int[0, 0];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] AdjacencyMatrix
        {
            get => _adjacencyMatrix;
            set
            {
                ValueValidator.AssertMatrixIsAdjacency(value, nameof(AdjacencyMatrix));
                _adjacencyMatrix = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get
            {
                return GraphFactory.CreateGraphByAdjacencyMatrix(AdjacencyMatrix);
            }
            set
            {
                AdjacencyMatrix = value.AdjacencyMatrix;
            }
        }

        public PathMatrixControl()
        {
            InitializeComponent();
        }

        private void PathLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _pathLength = (int)PathLengthNumericUpDown.Value;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = MatrixManager.Pow(AdjacencyMatrix, 
                _pathLength);
        }
    }
}
