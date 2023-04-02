using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Controls.PathControls
{
    /// <summary>
    /// Элемент управления для редактирования ребра.
    /// </summary>
    public partial class EdgeEditorControl : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт выбранное ребро.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Edge SelectedEdge
        {
            get => EdgeSelectorControl.SelectedEdge;
        }

        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set => EdgeSelectorControl.Graph = value;
        }

        /// <summary>
        /// Обработчик события изменения веса ребра.
        /// </summary>
        public event EventHandler EdgeWeightChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="EdgeEditorControl"/> по умолчанию.
        /// </summary>
        public EdgeEditorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            EdgeSelectorControl.RefreshData();
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedEdge == null)
            {
                WeightTextBox.Text = null;
            }
            else
            {
                try
                {
                    SelectedEdge.Weight = double.Parse(WeightTextBox.Text);
                    WeightTextBox.BackColor = ColorManager.CorrectColor;
                    ToolTip.RemoveAll();
                    EdgeWeightChanged?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    WeightTextBox.BackColor = ColorManager.ErrorColor;
                    ToolTip.SetToolTip(WeightTextBox, ex.Message);
                }
            }
        }

        private void EdgeSelectorControl_SelectedEdgeChanged(object sender, EventArgs e)
        {
            if(SelectedEdge == null)
            {
                WeightTextBox.Text = null;
            }
            else
            {
                WeightTextBox.Text = $"{SelectedEdge.Weight}";
            }
        }
    }
}