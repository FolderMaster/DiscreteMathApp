using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public abstract partial class MatrixGridControl<T> : UserControl
    {
        private int _columnCount = 0;

        private int _rowCount = 0;

        private T[,] _matrix = new T[0, 0];

        private DataTable _dataTable = new DataTable();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public T[,] Matrix
        {
            get => _matrix;
            set
            {
                if(!_matrix.Equals(value))
                {
                    _matrix = value;
                    _columnCount = value.GetLength(1);
                    _rowCount = value.GetLength(0);
                    _dataTable = CreateDataTable(_columnCount, _rowCount);
                    UpdateDataTable();
                    MatrixChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler MatrixChanged;

        public MatrixGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        private DataTable CreateDataTable(int columnCount, int rowCount)
        {
            DataTable dataTable = new DataTable();
            string[] columnStrings = CreateColumnStrings(columnCount);
            string[] rowStrings = CreateRowStrings(rowCount);

            dataTable.Columns.Add("*", typeof(int));
            for (int n = 0; n < columnCount; ++n)
            {
                dataTable.Columns.Add(columnStrings[n], typeof(int));
            }
            if (dataTable.Columns.Count > 0)
            {
                dataTable.Columns[0].ReadOnly = true;
            }

            for (int n = 0; n < rowCount; ++n)
            {
                dataTable.Rows.Add(rowStrings[n]);
            }

            return dataTable;
        }

        private void UpdateDataTable()
        {
            for (int y = 0; y < _rowCount; ++y)
            {
                for (int x = 0; x < _columnCount; x++)
                {
                    _dataTable.Rows[y][x + 1] = Matrix[y, x];
                }
            }
            DataGridView.DataSource = _dataTable;
        }

        protected abstract T Parse(string text);

        protected virtual void Validate(T value, int columnIndex, int rowIndex, T[,] matrix) {}

        protected virtual string[] CreateRowStrings(int count)
        {
            string[] result = new string[count];
            for(int n = 0; n < count; ++n)
            {
                result[n] = $"{n + 1}";
            }
            return result;
        }

        protected virtual string[] CreateColumnStrings(int count)
        {
            string[] result = new string[count];
            for (int n = 0; n < count; ++n)
            {
                result[n] = $"{n + 1}";
            }
            return result;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            try
            {
                T value = Parse((string)e.FormattedValue);
                Validate(value, columnIndex, rowIndex, Matrix);
                DataGridView[columnIndex, rowIndex].ErrorText = "";
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.CorrectColor;
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                DataGridView[columnIndex, rowIndex].ErrorText = ex.Message;
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.ErrorColor;
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            T currentValue = Parse(DataGridView[columnIndex, rowIndex].Value.ToString());
            if(!Matrix[rowIndex, columnIndex - 1].Equals(currentValue))
            {
                Matrix[rowIndex, columnIndex - 1] = currentValue;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}