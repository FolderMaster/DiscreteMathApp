using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Managers;

namespace GraphsApp.Views.Controls.MatrixControls
{
    /// <summary>
    /// Элемент управления для работы с матрицей количества путей.
    /// </summary>
    public partial class PathCountMatrixControl : UserControl
    {
        /// <summary>
        /// Длина пути.
        /// </summary>
        private int _pathLength = 1;

        /// <summary>
        /// Граф.
        /// </summary>
        private Graph _graph = new Graph();

        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set => _graph = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PathCountMatrixControl"/> по умолчанию.
        /// </summary>
        public PathCountMatrixControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = new int[0, 0];
        }

        private void PathLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _pathLength = (int)PathLengthNumericUpDown.Value;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix = MatrixManager.Pow(Graph.AdjacencyMatrix,
                _pathLength);
        }
    }
}