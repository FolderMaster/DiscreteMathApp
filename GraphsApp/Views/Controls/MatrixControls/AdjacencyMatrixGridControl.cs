using System.ComponentModel;

using GraphsApp.Services.Validators;

namespace GraphsApp.Views.Controls.MatrixControls
{
    /// <summary>
    /// Элемент управления для работы с матрицей смежности.
    /// </summary>
    public partial class AdjacencyMatrixGridControl : MatrixGridControl<int>
    {
        /// <summary>
        /// Возвращает и задаёт матрицу смежности.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] AdjacencyMatrix
        {
            get => Matrix;
            set => Matrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AdjacencyMatrixGridControl"/> по умолчанию.
        /// </summary>
        public AdjacencyMatrixGridControl()
        {
            InitializeComponent();
        }

        protected override int Parse(string text) => int.Parse(text);

        protected override void Validate(int value, int columnIndex, int rowIndex, int[,] matrix)
            => ValueValidator.AssertValueIsPositive(value, nameof(value));
    }
}