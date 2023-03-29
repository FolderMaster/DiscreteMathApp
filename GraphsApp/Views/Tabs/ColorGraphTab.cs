using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Tabs
{
    public partial class ColorGraphTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => ColorGraphControl.Graph;
            set => ColorGraphControl.Graph = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ColorGraphControlSession ColorGraphControlSession
        {
            get => ColorGraphControl.Session;
            set => ColorGraphControl.Session = value;
        }

        public ColorGraphTab()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            Schedule2DControl.Schedule = PlotFactory.CreateScheduleByGraph(Graph, true);
        }

        private void ColorGraphControl_ButtonClicked(object sender, EventArgs e)
        {
            Schedule2DControl.Schedule = PlotFactory.CreateScheduleByGraph(Graph, true);
        }
    }
}