using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Managers;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Controls.ColorControls
{
    /// <summary>
    /// Элемент управления для раскраски графа.
    /// </summary>
    public partial class ColorGraphControl : UserControl
    {
        /// <summary>
        /// Сессия элемента управления раскраски графа с цветами.
        /// </summary>
        private ColorGraphControlSession _session = new ColorGraphControlSession();

        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph { get; set; } = new Graph();

        /// <summary>
        /// Возвращает и задаёт сессию элемента управления раскраски графа с цветами.
        /// </summary>
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

        /// <summary>
        /// Обработчик события нажатия на кнопку.
        /// </summary>
        public event EventHandler ButtonClicked;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ColorGraphControl"/> по умолчанию.
        /// </summary>
        public ColorGraphControl()
        {
            InitializeComponent();

            ColorListControl.Colors = Session.Colors;
        }

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