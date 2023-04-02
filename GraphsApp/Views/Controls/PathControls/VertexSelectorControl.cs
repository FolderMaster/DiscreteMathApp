using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Controls.PathControls
{
    /// <summary>
    /// Элемент управления для выбора вершины.
    /// </summary>
    public partial class VertexSelectorControl : UserControl
    {
        /// <summary>
        /// Источник данных для <see cref="ComboBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Вершины.
        /// </summary>
        private List<Vertex> _vertices = new List<Vertex>();

        /// <summary>
        /// Выбранная вершина.
        /// </summary>
        private Vertex _selectedVertex = null;

        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт выбранную вершину.
        /// </summary>
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

        /// <summary>
        /// Обработчик события изменения выбранной вершины.
        /// </summary>
        public event EventHandler SelectedVertexChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="VertexSelectorControl"/> по умолчанию.
        /// </summary>
        public VertexSelectorControl()
        {
            InitializeComponent();

            ComboBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
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