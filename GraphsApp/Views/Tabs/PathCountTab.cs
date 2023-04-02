using System.ComponentModel;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;

namespace GraphsApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для работы с матрицей путей.
    /// </summary>
    public partial class PathCountTab : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт граф.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get => PathCountMatrixControl.Graph;
            set
            {
                AdjacencyMatrixGridControl.AdjacencyMatrix = value.AdjacencyMatrix;
                PathCountMatrixControl.Graph = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PathCountTab"/> по умолчанию.
        /// </summary>
        public PathCountTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            AdjacencyMatrixGridControl.AdjacencyMatrix =
                PathCountMatrixControl.Graph.AdjacencyMatrix;
            PathCountMatrixControl.RefreshData();
        }
    }
}