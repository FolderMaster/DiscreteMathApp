using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;
using GraphsApp.Views.Controls.Classes;

namespace GraphsApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для раскраски графа.
    /// </summary>
    public partial class ColorGraphTab : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => ColorGraphControl.Graph;
            set => ColorGraphControl.Graph = value;
        }

        /// <summary>
        /// Возвращает и задаёт сессия элемента управления раскраски графа с цветами.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ColorGraphControlSession ColorGraphControlSession
        {
            get => ColorGraphControl.Session;
            set => ColorGraphControl.Session = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ColorGraphTab"/> по умолчанию.
        /// </summary>
        public ColorGraphTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            Schedule2DControl.Plot = PlotFactory.CreateScheduleByGraph(Graph, true);
        }

        private void ColorGraphControl_ButtonClicked(object sender, EventArgs e)
        {
            Schedule2DControl.Plot = PlotFactory.CreateScheduleByGraph(Graph, true);
        }
    }
}