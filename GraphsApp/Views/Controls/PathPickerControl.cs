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
using GraphsApp.Services.Managers;

namespace GraphsApp.Views.Controls
{
    public partial class PathPickerControl : UserControl
    {
        private Graph _graph = new Graph();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Vertex FromSelectedVertex
        {
            get => FromVertexSelectorControl.SelectedVertex;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Vertex ToSelectedVertex
        {
            get => ToVertexSelectorControl.SelectedVertex;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => _graph;
            set => _graph = FromVertexSelectorControl.Graph = ToVertexSelectorControl.Graph = value;
        }

        public event EventHandler ButtonClicked;

        public PathPickerControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            FromVertexSelectorControl.RefreshData();
            ToVertexSelectorControl.RefreshData();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            double answer = GraphManager.GetLengthOfShortestPath(Graph, FromSelectedVertex,
                ToSelectedVertex);
            MessageBoxManager.ShowInformation($"Length of shortest path: {answer}");
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}