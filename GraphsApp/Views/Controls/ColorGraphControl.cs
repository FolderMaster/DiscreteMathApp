using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Managers;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Controls
{
    public partial class ColorGraphControl : UserControl
    {
        private ColorGraphControlSession _session = new ColorGraphControlSession();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph { get; set; } = new Graph();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ColorGraphControlSession Session
        {
            get => _session;
            set
            {
                _session = value;

                ColorPickerControl1.SelectedColor = Session.Color1;
                ColorPickerControl2.SelectedColor = Session.Color2;
                ColorPickerControl3.SelectedColor = Session.Color3;
                ColorPickerControl4.SelectedColor = Session.Color4;
            }
        }

        public ColorGraphControl()
        {
            InitializeComponent();

            ColorPickerControl1.SelectedColor = Session.Color1;
            ColorPickerControl2.SelectedColor = Session.Color2;
            ColorPickerControl3.SelectedColor = Session.Color3;
            ColorPickerControl4.SelectedColor = Session.Color4;
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

        private void ColorPickerControl1_SelectedColorChanged(object sender, EventArgs e)
        {
            Session.Color1 = ColorPickerControl1.SelectedColor;
        }

        private void ColorPickerControl2_SelectedColorChanged(object sender, EventArgs e)
        {
            Session.Color2 = ColorPickerControl2.SelectedColor;
        }

        private void ColorPickerControl3_SelectedColorChanged(object sender, EventArgs e)
        {
            Session.Color3 = ColorPickerControl3.SelectedColor;
        }

        private void ColorPickerControl4_SelectedColorChanged(object sender, EventArgs e)
        {
            Session.Color4 = ColorPickerControl4.SelectedColor;
        }
    }
}