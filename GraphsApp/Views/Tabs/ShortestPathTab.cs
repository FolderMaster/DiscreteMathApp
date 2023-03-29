using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Views.Controls;

namespace GraphsApp.Views.Tabs
{
    public partial class ShortestPathTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set => EdgeEditorControl.Graph = PathPickerControl.Graph = value;
        }

        public ShortestPathTab()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            PathPickerControl.RefreshData();
            EdgeEditorControl.RefreshData();
            Schedule2DControl.Schedule =
                PlotFactory.CreateScheduleByGraph(PathPickerControl.Graph);
        }

        private void PathPickerControl_ButtonClicked(object sender, EventArgs e)
        {
            Schedule2DControl.Schedule =
                PlotFactory.CreateScheduleByGraph(PathPickerControl.Graph, false, true);
        }
    }
}