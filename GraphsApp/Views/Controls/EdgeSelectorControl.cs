using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Controls
{
    public partial class EdgeSelectorControl : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<Edge> _edges = new List<Edge>();

        private Edge _selectedEdge = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set
            {
                _edges = value.Edges;
                _bindingSource.DataSource = _edges;
                if (_edges.Count > 0)
                {
                    ComboBox.SelectedIndex = 0;
                    SelectedEdge = (Edge)ComboBox.SelectedItem;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Edge SelectedEdge
        {
            get => _selectedEdge;
            set
            {
                if (SelectedEdge != value)
                {
                    _selectedEdge = value;
                    SelectedEdgeChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler SelectedEdgeChanged;

        public EdgeSelectorControl()
        {
            InitializeComponent();

            ComboBox.DataSource = _bindingSource;
        }

        public void RefreshData()
        {
            _bindingSource.ResetBindings(false);
            SelectedEdge = (Edge)ComboBox.SelectedItem;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEdge = (Edge)ComboBox.SelectedItem;
        }
    }
}