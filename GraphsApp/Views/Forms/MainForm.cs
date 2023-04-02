using System;
using System.Windows.Forms;

using GraphsApp.Services.App;
using GraphsApp.Services.IO;

namespace GraphsApp.Views.Forms
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Настройки.
        /// </summary>
        private Settings _settings = new Settings();

        /// <summary>
        /// сессия.
        /// </summary>
        private Session _session = new Session();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/> по умолчанию.
        /// </summary>
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
                _session = save == null ? _session : new Session(save);
                CreatorMatrixTab.Graph = PathCountTab.Graph = ShortestPathTab.Graph =
                    ColorGraphTab.Graph = _session.Graph;
                CreatorMatrixTab.AdjacencyMatrixControlSession =
                    _session.AdjacencyMatrixControlSession;
                CreatorMatrixTab.IncidenceMatrixControlSession =
                    _session.IncidenceMatrixControlSession;
                ColorGraphTab.ColorGraphControlSession = _session.ColorGraphControlSession;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SaveFormat save = new SaveFormat(_session);
                JsonManager.Save(save, _settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void AdjacencyMatrixTab_MatrixChanged(object sender, EventArgs e)
        {
            PathCountTab.RefreshData();
            ShortestPathTab.RefreshData();
            ColorGraphTab.RefreshData();
        }
    }
}