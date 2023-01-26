using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class MatrixControl : UserControl
    {
        private MatrixControlSession _session = new MatrixControlSession();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MatrixControlSession Session
        {
            get => _session;
            set
            {
                _session = value;
                VerticesCountNumericUpDown.Value = Session.VerticesCount;
                EdgesCountNumericUpDown.Value = Session.EdgesCount;
                EdgeMultiplicityNumericUpDown.Value = Session.EdgeMultiplicity;
                LoopsCountNumericUpDown.Value = Session.LoopsCount;
            }
        }

        public MatrixControl()
        {
            InitializeComponent();
        }

        protected virtual void FillButtonClick() {}

        protected virtual void GenerationButtonClick() { }

        private void VerticesCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Session.VerticesCount = (int)VerticesCountNumericUpDown.Value;
        }

        private void EdgeMultiplicityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Session.EdgeMultiplicity = (int)EdgeMultiplicityNumericUpDown.Value;
        }

        private void LoopsCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Session.LoopsCount = (int)LoopsCountNumericUpDown.Value;
        }

        private void EdgesCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Session.EdgesCount = (int)EdgesCountNumericUpDown.Value;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            FillButtonClick();
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            GenerationButtonClick();
        }
    }
}