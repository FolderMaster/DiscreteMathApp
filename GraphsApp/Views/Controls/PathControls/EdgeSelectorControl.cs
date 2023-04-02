using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Controls.PathControls
{
    /// <summary>
    /// Элемент управления для выбора ребра.
    /// </summary>
    public partial class EdgeSelectorControl : UserControl
    {
        /// <summary>
        /// Источник данных для <see cref="ComboBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Рёбра.
        /// </summary>
        private List<Edge> _edges = new List<Edge>();

        /// <summary>
        /// Выбранное ребро.
        /// </summary>
        private Edge _selectedEdge = null;

        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт выбранное ребро.
        /// </summary>
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

        /// <summary>
        /// Обработчик события изменения выбранного ребра.
        /// </summary>
        public event EventHandler SelectedEdgeChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="EdgeSelectorControl"/> по умолчанию.
        /// </summary>
        public EdgeSelectorControl()
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
            SelectedEdge = (Edge)ComboBox.SelectedItem;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEdge = (Edge)ComboBox.SelectedItem;
        }
    }
}