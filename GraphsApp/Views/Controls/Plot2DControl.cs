using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using GraphsApp.Models.Plots;
using GraphsApp.Services.App;

namespace GraphsApp.Views.Controls
{
    public partial class Plot2DControl : UserControl
    {
        private Plot2D _schedule;

        private Settings _settings;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Plot2D Schedule
        {
            get
            {
                return _schedule;
            }
            set
            {
                if (value != null)
                {
                    _schedule = value;
                    _schedule.Axises2D[0].Length = Width;
                    _schedule.Axises2D[1].Length = Height;
                    _schedule.DefaultDisplay();

                    Invalidate();
                }
            }
        }

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

        public Plot2DControl()
        {
            InitializeComponent();

            Schedule = new Plot2D(new List<Axis>() {
                new Axis(new LinearScale()), new Axis(new LinearScale()) });
            Settings = new Settings();
        }

        private void Schedule2DControl_Resize(object sender, EventArgs e)
        {
            Schedule.Axises2D[0].Length = Width;
            Schedule.Axises2D[1].Length = Height;

            Invalidate();
        }

        private void Schedule2DControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();

            List<IShape> display = Schedule.Displays;
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