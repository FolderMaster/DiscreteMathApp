using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphsApp.Views.Controls
{
    public partial class ColorListControl : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<Color> _colors = new List<Color>();

        private int _selectedIndex = -1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Color> Colors
        {
            get => _colors;
            set
            {
                _colors = value;
                _bindingSource.DataSource = _colors;
                UpdateList();
            }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if(_selectedIndex != value)
                {
                    _selectedIndex = value;
                    if(SelectedIndex != -1)
                    {
                        EditColorPickerControl.SelectedColor = SelectedColor;
                    }
                    else
                    {
                        EditColorPickerControl.SelectedColor = new Color();
                    }
                }
            }
        }

        public Color SelectedColor
        {
            get => _colors[SelectedIndex];
            set
            {
                if(SelectedIndex != -1)
                {
                    if (Colors[SelectedIndex] != value)
                    {
                        _colors[SelectedIndex] = value;
                        UpdateList();
                        EditColorPickerControl.SelectedColor = SelectedColor;
                    }
                }
                
            }
        }

        public ColorListControl()
        {
            InitializeComponent();

            ListBox.DataSource = _bindingSource;
        }

        private void UpdateList()
        {
            _bindingSource.ResetBindings(false);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = ListBox.SelectedIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Colors.Add(new Color());
            UpdateList();
            if(Colors.Count == 1)
            {
                SelectedIndex = 0;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(SelectedIndex != -1)
            {
                Colors.RemoveAt(SelectedIndex);
                UpdateList();
            }
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            ListBox listBox = (ListBox)sender;
            if(e.Index != -1)
            {
                e.Graphics.FillRectangle(new SolidBrush((Color)listBox.Items[e.Index]), e.Bounds);
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font,
                    new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));
            }
            e.DrawFocusRectangle();
        }

        private void EditColorPickerControl_SelectedColorChanged(object sender, EventArgs e)
        {
            SelectedColor = EditColorPickerControl.SelectedColor;
        }
    }
}