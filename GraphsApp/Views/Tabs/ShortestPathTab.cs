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

namespace GraphsApp.Views.Tabs
{
    public partial class ShortestPathTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set => EdgeEditorControl.Graph = PathPickerControl.Graph = value;
        }

        public ShortestPathTab()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            PathPickerControl.RefreshData();
            EdgeEditorControl.RefreshData();
        }
    }
}