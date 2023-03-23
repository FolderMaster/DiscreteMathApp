using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Managers;

namespace GraphsApp.Views.Controls.PathControls
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
            try
            {
                (double, List <Edge>) answer = GraphManager.GetLengthOfShortestPath(Graph,
                    FromSelectedVertex, ToSelectedVertex);
                ButtonClicked?.Invoke(this, EventArgs.Empty);
                double pathLength = answer.Item1;
                if(pathLength == double.PositiveInfinity)
                {
                    MessageBoxManager.ShowInformation("Path not found!");
                }
                else if(pathLength == 0 && answer.Item2.Count == 0)
                {
                    MessageBoxManager.ShowInformation("No path required!");
                }
                else
                {
                    string path = "";
                    answer.Item2.ForEach((edge) => path += edge.Name);
                    MessageBoxManager.ShowInformation($"Shortest path: {path}\nLength of " +
                        $"shortest path: {pathLength}");
                }
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}