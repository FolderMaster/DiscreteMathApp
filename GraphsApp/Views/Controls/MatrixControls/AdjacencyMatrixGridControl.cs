using System.ComponentModel;

using GraphsApp.Services.Validatories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class AdjacencyMatrixGridControl : MatrixGridControl<int>
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] AdjacencyMatrix
        {
            get => Matrix;
            set => Matrix = value;
        }

        public AdjacencyMatrixGridControl()
        {
            InitializeComponent();
        }

        protected override int Parse(string text) => int.Parse(text);

        protected override void Validate(int value, int columnIndex, int rowIndex, int[,] matrix)
            => ValueValidator.AssertValueIsPositive(value, nameof(value));
    }
}