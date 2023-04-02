using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для создания матриц.
    /// </summary>
    public partial class CreatorMatrixTab : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => AdjacencyMatrixControl.Graph;
            set => AdjacencyMatrixControl.Graph = IncidenceMatrixControl.Graph = value;
        }

        /// <summary>
        /// Возвращает и задаёт сессию элемента управления матрицы смежности.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MatrixControlSession AdjacencyMatrixControlSession
        {
            get => AdjacencyMatrixControl.Session;
            set => AdjacencyMatrixControl.Session = value;
        }

        /// <summary>
        /// Возвращает и задаёт сессию элемента управления матрицы инцидентности.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MatrixControlSession IncidenceMatrixControlSession
        {
            get => IncidenceMatrixControl.Session;
            set => IncidenceMatrixControl.Session = value;
        }

        /// <summary>
        /// Обработчик события изменения матрицы.
        /// </summary>
        public event EventHandler MatrixChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CreatorMatrixTab"/> по умолчанию.
        /// </summary>
        public CreatorMatrixTab()
        {
            InitializeComponent();
        }

        private void AdjacencyMatrixControl_MatrixChanged(object sender, EventArgs e)
        {
            Schedule2DControl.Plot =
                PlotFactory.CreateScheduleByGraph(AdjacencyMatrixControl.Graph);
            IncidenceMatrixControl.RefreshData();
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void IncidenceMatrixControl_MatrixChanged(object sender, EventArgs e)
        {
            Schedule2DControl.Plot =
                PlotFactory.CreateScheduleByGraph(IncidenceMatrixControl.Graph);
            AdjacencyMatrixControl.RefreshData();
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            Schedule2DControl.Plot = PlotFactory.CreateScheduleByGraph(Graph);
        }
    }
}