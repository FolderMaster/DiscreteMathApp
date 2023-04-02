using System.ComponentModel;

using GraphsApp.Services.Validators;

namespace GraphsApp.Views.Controls.MatrixControls
{
    /// <summary>
    /// Элемент управления для редактирования значений матрица инцидентности.
    /// </summary>
    public partial class IncidenceMatrixGridControl : MatrixGridControl<int>
    {
        /// <summary>
        /// Возвращает и задаёт матрицу инцидентности.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] IncidenceMatrix
        {
            get => Matrix;
            set => Matrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="IncidenceMatrixGridControl"/> по умолчанию.
        /// </summary>
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