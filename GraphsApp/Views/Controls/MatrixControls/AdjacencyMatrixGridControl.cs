using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Validatories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class AdjacencyMatrixGridControl : MatrixGridControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] AdjacencyMatrix
        {
            get => Matrix;
            set
            { 
                ValueValidator.AssertMatrixIsAdjacency(value, nameof(AdjacencyMatrix));
                Matrix = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get
            {
                Graph result = new Graph();
                result.AdjacencyMatrix = AdjacencyMatrix;
                return result;
            }
            set => AdjacencyMatrix = value.AdjacencyMatrix;
        }

        public AdjacencyMatrixGridControl()
        {
            InitializeComponent();
        }

        protected override void Validate(int value)
        {
            ValueValidator.AssertValueIsPositive(value, "Matrix");
        }
    }
}