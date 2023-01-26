using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Controls
{
    public partial class VertexSelectorControl : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<Vertex> _vertices = new List<Vertex>();

        private Vertex _selectedVertex = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set
            {
                _vertices = value.Vertices;
                _bindingSource.DataSource = _vertices;
                if (_vertices.Count > 0)
                {
                    ComboBox.SelectedIndex = 0;
                    SelectedVertex = (Vertex)ComboBox.SelectedItem;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Vertex SelectedVertex
        {
            get => _selectedVertex;
            set
            {
                if (SelectedVertex != value)
                {
                    _selectedVertex = value;
                    SelectedVertexChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler SelectedVertexChanged;

        public VertexSelectorControl()
        {
            InitializeComponent();

            ComboBox.DataSource = _bindingSource;
        }

        public void RefreshData()
        {
            _bindingSource.ResetBindings(false);
            SelectedVertex = (Vertex)ComboBox.SelectedItem;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedVertex = (Vertex)ComboBox.SelectedItem;
        }
    }
}