using System;
using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Services.Factories;

namespace GraphsApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для нахождения кратчайшего пути.
    /// </summary>
    public partial class ShortestPathTab : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set => EdgeEditorControl.Graph = PathPickerControl.Graph = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ShortestPathTab"/> по умолчанию.
        /// </summary>
        public ShortestPathTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            PathPickerControl.RefreshData();
            EdgeEditorControl.RefreshData();
            Schedule2DControl.Plot =
                PlotFactory.CreateScheduleByGraph(PathPickerControl.Graph);
        }

        private void PathPickerControl_ButtonClicked(object sender, EventArgs e)
        {
            Schedule2DControl.Plot =
                PlotFactory.CreateScheduleByGraph(PathPickerControl.Graph, false, true);
        }
    }
}