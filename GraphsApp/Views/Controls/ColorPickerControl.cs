using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphsApp.Views.Controls.MatrixControls
{
    public partial class ColorPickerControl : UserControl
    {
        private Color _selectedColor = Color.Black;

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

        public string ButtonText
        {
            set => Button.Text = value;
        }

        public event EventHandler SelectedColorChanged;

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