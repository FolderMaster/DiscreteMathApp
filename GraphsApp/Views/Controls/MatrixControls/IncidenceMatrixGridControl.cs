using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Services.Validatories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class IncidenceMatrixGridControl : MatrixGridControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] IncidenceMatrix
        {
            get => Matrix;
            set
            {
                Matrix = value;
            }
        }

        public IncidenceMatrixGridControl()
        {
            InitializeComponent();
        }

        protected override void Validate(int value)
        {
        }

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