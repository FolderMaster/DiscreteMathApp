using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Controls.MatrixControls
{
    /// <summary>
    /// Элемент управления для работы с матрицей.
    /// </summary>
    public partial class MatrixControl : UserControl
    {
        /// <summary>
        /// Сессия элемента управления матрицы.
        /// </summary>
        private MatrixControlSession _session = new MatrixControlSession();

        /// <summary>
        /// Возвращает и задаёт логическое значение, указывающее, что <see cref="SetButton"/>
        /// доступна.
        /// </summary>
        protected bool IsSetButtonEnable
        {
            get => SetButton.Enabled;
            set => SetButton.Enabled = value;
        }

        /// <summary>
        /// Возвращает и задаёт логическое значение, указывающее, что <see cref="ResetButton"/>
        /// доступна.
        /// </summary>
        protected bool IsResetButtonEnable
        {
            get => ResetButton.Enabled;
            set => ResetButton.Enabled = value;
        }

        /// <summary>
        /// Возвращает и задаёт сессии.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MatrixControl"/> по умолчанию.
        /// </summary>
        public MatrixControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который срабатывает при нажатии на <see cref="FillButton"/>.
        /// </summary>
        protected virtual void FillButtonClick() {}

        /// <summary>
        /// Метод, который срабатывает при нажатии на <see cref="GenerationButton"/>.
        /// </summary>
        protected virtual void GenerationButtonClick() {}

        /// <summary>
        /// Метод, который срабатывает при нажатии на <see cref="SetButton"/>.
        /// </summary>
        protected virtual void SetButtonClick() {}

        /// <summary>
        /// Метод, который срабатывает при нажатии на <see cref="ResetButton"/>.
        /// </summary>
        protected virtual void ResetButtonClick() {}

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