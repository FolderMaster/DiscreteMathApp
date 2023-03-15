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

                ColorListControl.Colors = Session.Colors;
            }
        }

        public ColorGraphControl()
        {
            InitializeComponent();

            ColorListControl.Colors = Session.Colors;
        }

        public event EventHandler ButtonClicked;

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                GraphManager.ColorGraph(Graph, new List<Color>(ColorListControl.Colors));
                ButtonClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}