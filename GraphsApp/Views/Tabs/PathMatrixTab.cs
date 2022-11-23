using GraphsApp.Models.Graphs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GraphsApp.Views.Tabs
{
    public partial class PathMatrixTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] AdjacencyMatrix
        {
            get
            {
                return AdjacencyMatrixGridControl.AdjacencyMatrix;
            }
            set
            {
                AdjacencyMatrixGridControl.AdjacencyMatrix = value;
                PathMatrixControl.AdjacencyMatrix = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get
            {
                return AdjacencyMatrixGridControl.Graph;
            }
            set
            {
                AdjacencyMatrixGridControl.Graph = value;
                PathMatrixControl.Graph = value;
            }
        }

        public PathMatrixTab()
        {
            InitializeComponent();
        }
    }
}
