using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using GraphsApp.Models.Graphs;
using GraphsApp.Models.Schedules;
using GraphsApp.Services.App;
using GraphsApp.Services.Factories;

using Point = GraphsApp.Models.Schedules.Point;

namespace GraphsApp.Views.Controls
{
    public partial class Schedule2DControl : UserControl
    {
        private Schedule2D _schedule;

        private Settings _settings;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            set
            {
                Schedule = ScheduleFactory.CreateScheduleByGraph(value);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Schedule2D Schedule
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

        public Schedule2DControl()
        {
            InitializeComponent();

            Schedule = new Schedule2D(new List<Axis>() {
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
                if (display[n] is Point point)
                {
                    int x = (int)point[0];
                    int y = (int)point[1];

                    graphics.DrawEllipse(Settings.OuterPointPen, x - Settings.PointSize / 2, Height
                        - y - Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                    graphics.FillEllipse(new SolidBrush(point.Color), x - Settings.PointSize / 2,
                        Height - y - Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                    graphics.DrawString(point.Name, Settings.ValueFont, Settings.FontSolidBrush, 
                        x, Height - y);
                }
                else if (display[n] is Curve curve)
                {
                    int xBegin = (int)curve.Begin[0];
                    int yBegin = (int)curve.Begin[1];
                    int xMiddle = (int)curve.Middle[0];
                    int yMiddle = (int)curve.Middle[1];
                    int xEnd = (int)curve.End[0];
                    int yEnd = (int)curve.End[1];

                    graphics.DrawCurve(Settings.LinePen, new PointF[3]
                    {
                        new PointF(xBegin, Height - yBegin),
                        new PointF(xMiddle, Height - yMiddle),
                        new PointF(xEnd, Height - yEnd)
                    });
                    graphics.DrawString(curve.Name, Settings.ValueFont, Settings.FontSolidBrush,
                        xMiddle, Height - yMiddle);
                }
            }
        }
    }
}
