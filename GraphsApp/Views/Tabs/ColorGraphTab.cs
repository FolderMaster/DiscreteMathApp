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
            Schedule2DControl.Graph = new Graph();
        }

        private void ColorGraphControl_ButtonClicked(object sender, EventArgs e)
        {
            Schedule2DControl.Graph = Graph;
        }
    }
}