using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Views.Controls;
using GraphsApp.Views.Controls.Classes;
using Newtonsoft.Json.Linq;

namespace GraphsApp.Views.Tabs
{
    public partial class CreatorMatrixTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => AdjacencyMatrixControl.Graph;
            set => AdjacencyMatrixControl.Graph = IncidenceMatrixControl.Graph = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MatrixControlSession AdjacencyMatrixControlSession
        {
            get => AdjacencyMatrixControl.Session;
            set => AdjacencyMatrixControl.Session = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MatrixControlSession IncidenceMatrixControlSession
        {
            get => IncidenceMatrixControl.Session;
            set => IncidenceMatrixControl.Session = value;
        }

        public event EventHandler MatrixChanged;

        public CreatorMatrixTab()
        {
            InitializeComponent();
        }

        private void AdjacencyMatrixControl_MatrixChanged(object sender, EventArgs e)
        {
            Schedule2DControl.Schedule =
                ScheduleFactory.CreateScheduleByGraph(AdjacencyMatrixControl.Graph);
            IncidenceMatrixControl.RefreshData();
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void IncidenceMatrixControl_MatrixChanged(object sender, EventArgs e)
        {
            Schedule2DControl.Schedule =
                ScheduleFactory.CreateScheduleByGraph(IncidenceMatrixControl.Graph);
            AdjacencyMatrixControl.RefreshData();
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            Schedule2DControl.Schedule = ScheduleFactory.CreateScheduleByGraph(Graph);
        }
    }
}