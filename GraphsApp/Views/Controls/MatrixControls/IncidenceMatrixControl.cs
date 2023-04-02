using System;
using System.ComponentModel;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Controls.MatrixControls
{
    /// <summary>
    /// Элемент управления для работы с матрицей инцидентности.
    /// </summary>
    public partial class IncidenceMatrixControl : MatrixControl
    {
        /// <summary>
        /// Граф.
        /// </summary>
        private Graph _graph = new Graph();

        /// <summary>
        /// Возвращает и задаёт матрицу инцидентности.
        /// </summary>
        private int[,] IncidenceMatrix
        {
            get => IncidenceMatrixGridControl.IncidenceMatrix;
            set => IncidenceMatrixGridControl.IncidenceMatrix = value;
        }

        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set
            {
                _graph = value;
                IncidenceMatrix = _graph.IncidenceMatrix;
                IsResetButtonEnable = false;
                IsSetButtonEnable = false;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик события изменения матрицы.
        /// </summary>
        public event EventHandler MatrixChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="IncidenceMatrixControl"/> по умолчанию.
        /// </summary>
        public IncidenceMatrixControl()
        {
            InitializeComponent();
        }

        protected override void FillButtonClick()
        {
            IncidenceMatrix = MatrixFactory.CreateIncidentMatrix(Session.VerticesCount,
                Session.EdgesCount);
        }

        protected override void GenerationButtonClick()
        {
            IncidenceMatrix = MatrixFactory.CreateIncidentMatrix(Session.VerticesCount,
                Session.EdgesCount, Session.LoopsCount, Session.EdgeMultiplicity,
                Session.AreOrientedConnections);
        }

        protected override void SetButtonClick()
        {
            try
            {
                Graph.IncidenceMatrix = IncidenceMatrix;
                IsResetButtonEnable = false;
                IsSetButtonEnable = false;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        protected override void ResetButtonClick()
        {
            IncidenceMatrix = Graph.IncidenceMatrix;
            IsResetButtonEnable = false;
            IsSetButtonEnable = false;
        }

        public void RefreshData()
        {
            IncidenceMatrix = Graph.IncidenceMatrix;
            IsResetButtonEnable = false;
            IsSetButtonEnable = false;
        }

        private void IncidenceMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            IsResetButtonEnable = true;
            IsSetButtonEnable = true;
        }
    }
}