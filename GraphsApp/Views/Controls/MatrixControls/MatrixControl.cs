using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class MatrixControl : UserControl
    {
        private MatrixControlSession _session = new MatrixControlSession();

        protected bool IsSetButtonEnable
        {
            get => SetButton.Enabled;
            set => SetButton.Enabled = value;
        }

        protected bool IsResetButtonEnable
        {
            get => ResetButton.Enabled;
            set => ResetButton.Enabled = value;
        }

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
                AreOrientedConnectionsCheckBox.Checked = Session.AreOrientedConnections;
            }
        }

        public MatrixControl()
        {
            InitializeComponent();
        }

        protected virtual void FillButtonClick() {}

        protected virtual void GenerationButtonClick() { }

        protected virtual void SetButtonClick() { }

        protected virtual void ResetButtonClick() { }

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

        private void AreOrientedConnectionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Session.AreOrientedConnections = AreOrientedConnectionsCheckBox.Checked;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            FillButtonClick();
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            GenerationButtonClick();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            SetButtonClick();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetButtonClick();
        }
    }
}