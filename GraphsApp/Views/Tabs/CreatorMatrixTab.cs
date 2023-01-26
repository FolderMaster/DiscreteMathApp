using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Views.Controls;
using GraphsApp.Views.Controls.Classes;

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
            IncidenceMatrixControl.RefreshData();
            Schedule2DControl.Graph = AdjacencyMatrixControl.Graph;
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void IncidenceMatrixControl_MatrixChanged(object sender, EventArgs e)
        {
            //AdjacencyMatrixControl.RefreshData();
            Schedule2DControl.Graph = IncidenceMatrixControl.Graph;
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            Schedule2DControl.Graph = AdjacencyMatrixControl.Graph;
        }
    }
}