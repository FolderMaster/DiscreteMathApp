using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphsApp.Views.Controls.ColorControls
{
    /// <summary>
    /// Элемент управления для выбора цвета.
    /// </summary>
    public partial class ColorPickerControl : UserControl
    {
        /// <summary>
        /// Выбранный цвет.
        /// </summary>
        private Color _selectedColor = Color.Black;

        /// <summary>
        /// Возвращает и задаёт выбранный цвет.
        /// </summary>
        public Color SelectedColor
        {
            get => _selectedColor;
            set
            {
                if(value != _selectedColor)
                {
                    _selectedColor = value;
                    Button.BackColor = SelectedColor;
                    SelectedColorChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт текст кнопки.
        /// </summary>
        public string ButtonText
        {
            get => Button.Text;
            set => Button.Text = value;
        }

        /// <summary>
        /// Обработчик события изменения выбранного цвета.
        /// </summary>
        public event EventHandler SelectedColorChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ColorPickerControl"/> по умолчанию.
        /// </summary>
        public ColorPickerControl()
        {
            InitializeComponent();

            Button.BackColor = SelectedColor;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog.Color;
            }
        }
    }
}