using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Controls
{
    public partial class EdgeEditorControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Edge SelectedEdge
        {
            get => EdgeSelectorControl.SelectedEdge;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set => EdgeSelectorControl.Graph = value;
        }

        public event EventHandler EdgeWeightChanged;

        public EdgeEditorControl()
        {
            InitializeComponent();
        }

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