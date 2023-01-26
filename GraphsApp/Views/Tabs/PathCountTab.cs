using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Tabs
{
    public partial class PathCountTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => PathCountMatrixControl.Graph;
            set
            {
                AdjacencyMatrixGridControl.Graph = value;
                PathCountMatrixControl.Graph = value;
            }
        }

        public PathCountTab()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            AdjacencyMatrixGridControl.Graph = Graph;
            PathCountMatrixControl.RefreshData();
        }
    }
}
