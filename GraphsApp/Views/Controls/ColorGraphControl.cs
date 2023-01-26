using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Managers;

namespace GraphsApp.Views.Controls
{
    public partial class ColorGraphControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph { get; set; } = new Graph();

        public ColorGraphControl()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClicked;

        private void Button_Click(object sender, EventArgs e)
        {
            GraphManager.ColorGraph(Graph, new List<Color>()
            {
                ColorPickerControl1.SelectedColor,
                ColorPickerControl2.SelectedColor,
                ColorPickerControl3.SelectedColor,
                ColorPickerControl4.SelectedColor
            });
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
