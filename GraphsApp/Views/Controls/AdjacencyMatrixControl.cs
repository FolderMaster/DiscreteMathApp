using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Services.Validatories;

namespace GraphsApp.Views.Controls
{
    public partial class AdjacencyMatrixControl : UserControl
    {
        private int _matrixSize = 0;

        private int[,] _adjacencyMatrix = new int[0, 0];

        private DataTable _dataTable = CreateDataTable(0);

        public int[,] AdjacencyMatrix
        {
            get => _adjacencyMatrix;
            set
            {
                ValueValidator.AssertMatrixIsAdjacency(value, nameof(AdjacencyMatrix));
                _adjacencyMatrix = value;
                _matrixSize = value.GetLength(0);
                _dataTable = CreateDataTable(_matrixSize);
                UpdateDataTable();
            }
        }

        public Graph Graph
        {
            get
            {
                return GraphFactory.CreateGraphByAdjacencyMatrix(AdjacencyMatrix);
            }
        }

        public AdjacencyMatrixControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        private static DataTable CreateDataTable(int count)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("*", typeof(int));
            for (int n = 0; n < count; ++n)
            {
                dataTable.Columns.Add(n.ToString(), typeof(int));
            }
            if (dataTable.Columns.Count > 0)
            {
                dataTable.Columns[0].ReadOnly = true;
            }

            for (int n = 0; n < count; ++n)
            {
                dataTable.Rows.Add(n);
            }

            return dataTable;
        }

        private void UpdateDataTable()
        {
            for(int y = 0; y < _matrixSize; ++y)
            {
                for(int x = 0; x < _matrixSize; x++)
                {
                    _dataTable.Rows[y][x + 1] = AdjacencyMatrix[y, x];
                }
            }
            DataGridView.DataSource = _dataTable;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs
            e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            try
            {
                int value = int.Parse((string)e.FormattedValue);
                ValueValidator.AssertValueIsPositive(value, $"matrix[{rowIndex}, " +
                    $"{columnIndex - 1}]");
                DataGridView[columnIndex, rowIndex].ErrorText = "";
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.CorrectColor;
            }
            catch(Exception ex)
            {
                e.Cancel = true;
                DataGridView[columnIndex, rowIndex].ErrorText = ex.Message;
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.ErrorColor;
            }
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = int.Parse(VerticesCountTextBox.Text);
                AdjacencyMatrix = MatrixFactory.CreateAdjacencyMatrix(count, count - 1);
                VerticesCountTextBox.BackColor = ColorManager.CorrectColor;
            }
            catch
            {
                VerticesCountTextBox.BackColor = ColorManager.ErrorColor;
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            object value = DataGridView[columnIndex, rowIndex].Value;
            string stringValue = value == null ? "" : value.ToString();
            AdjacencyMatrix[rowIndex, columnIndex - 1] = int.Parse(stringValue);
        }
    }
}
