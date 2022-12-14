using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GraphsApp.Services.App;
using GraphsApp.Services.Factories;
using GraphsApp.Services.IO;

namespace GraphsApp.Views.Forms
{
    public partial class MainForm : Form
    {
        private Settings _settings = new Settings();

        private Session _session = new Session();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveFormat save = new SaveFormat();
            try
            {
                save = JsonManager.Load<SaveFormat>(_settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
            finally
            {
                _session = save == null ? _session : new Session(GraphFactory.CreateGraphByAdjacencyMatrix(save.Graph));
                AdjacencyMatrixTab.Graph = _session.Graph;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                SaveFormat save = new SaveFormat(_session.Graph.AdjacencyMatrix);
                JsonManager.Save(save, _settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void AdjacencyMatrixTab_MatrixChanged(object sender, EventArgs e)
        {
            _session.Graph = AdjacencyMatrixTab.Graph;
            PathMatrixTab.AdjacencyMatrix = AdjacencyMatrixTab.AdjacencyMatrix;
        }
    }
}