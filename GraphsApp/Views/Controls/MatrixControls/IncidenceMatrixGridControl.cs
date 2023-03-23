using System.ComponentModel;

using GraphsApp.Services.Validatories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class IncidenceMatrixGridControl : MatrixGridControl<int>
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] IncidenceMatrix
        {
            get => Matrix;
            set => Matrix = value;
        }

        public IncidenceMatrixGridControl()
        {
            InitializeComponent();
        }

        protected override int Parse(string text) => int.Parse(text);

        protected override void Validate(int value, int columnIndex, int rowIndex, int[,] matrix)
            => ValueValidator.AssertValueIsInRange(value, -1, true, 2, true, nameof(value));

        protected override string[] CreateColumnStrings(int count)
        {
            string[] result = new string[count];
            int begin = (int)'a';
            for (int n = 0; n < count; ++n)
            {
                result[n] = $"{(char)(begin + n)}";
            }
            return result;
        }
    }
}