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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get
            {
                Graph result = new Graph();
                result.IncidenceMatrix = IncidenceMatrix;
                return result;
            }
            set => IncidenceMatrix = value.IncidenceMatrix;
        }

        public IncidenceMatrixGridControl()
        {
            InitializeComponent();
        }

        protected override void Validate(int value)
        {
            ValueValidator.AssertValueIsPositive(value, "Matrix");
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