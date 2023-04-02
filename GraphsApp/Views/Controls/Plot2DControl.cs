using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using GraphsApp.Models.Plots;
using GraphsApp.Services.App;

namespace GraphsApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для отображения графика.
    /// </summary>
    public partial class Plot2DControl : UserControl
    {
        /// <summary>
        /// График.
        /// </summary>
        private Plot2D _plot;

        /// <summary>
        /// Настройки.
        /// </summary>
        private Settings _settings;

        /// <summary>
        /// Возвращает и задаёт график.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Plot2D Plot
        {
            get
            {
                return _plot;
            }
            set
            {
                if (value != null)
                {
                    _plot = value;
                    _plot.Axes2D[0].Length = Width;
                    _plot.Axes2D[1].Length = Height;
                    _plot.DefaultDisplay();

                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт настройки.
        /// </summary>
        public Settings Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Plot2DControl"/> по умолчанию.
        /// </summary>
        public Plot2DControl()
        {
            InitializeComponent();

            Plot = new Plot2D(new List<Axis>() {
                new Axis(new LinearScale()), new Axis(new LinearScale()) });
            Settings = new Settings();
        }

        private void Schedule2DControl_Resize(object sender, EventArgs e)
        {
            Plot.Axes2D[0].Length = Width;
            Plot.Axes2D[1].Length = Height;

            Invalidate();
        }

        private void Schedule2DControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();

            List<IShape> display = Plot.Displays;
            for (int n = 0; n < display.Count; ++n)
            {
                if (display[n] is IDrawable drawable)
                {
                    drawable.Draw(graphics, Settings, Height, Width);
                }
            }
        }
    }
}