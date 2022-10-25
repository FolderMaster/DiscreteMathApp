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
using GraphsApp.Models.Schedules;
using GraphsApp.Services.App;
using GraphsApp.Services.Factories;

using Point = GraphsApp.Models.Schedules.Point;

namespace GraphsApp.Views.Controls
{
    public partial class Schedule2DControl : UserControl
    {
        private Graph _graph;

        private Schedule2D _schedule;

        private Settings _settings;

        public Graph Graph
        {
            set
            {
                _graph = value;
                Schedule = ScheduleFactory.CreateScheduleByGraph(value);
            }
        }

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
                    _schedule.Axises[0].Length = Width;
                    _schedule.Axises[1].Length = Height;
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
            Schedule.Axises[0].Length = Width;
            Schedule.Axises[1].Length = Height;

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
                    int x = (int)point.Coordinates[0];
                    int y = (int)point.Coordinates[1];

                    graphics.DrawEllipse(Settings.OuterPointPen, x - Settings.PointSize / 2, Height
                        - y - Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                    graphics.FillEllipse(Settings.InnerPointSolidBrush, x - Settings.PointSize / 2,
                        Height - y - Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                    graphics.DrawString(point.Name, Settings.ValueFont, Settings.FontSolidBrush, x, Height - y);
                }
                else if (display[n] is LineSegment lineSegment)
                {
                    if(lineSegment.Begin.Coordinates[0] == lineSegment.End.Coordinates[0] && lineSegment.End.Coordinates[1] == lineSegment.End.Coordinates[1])
                    {
                        int x = (int)lineSegment.Begin.Coordinates[0] - Settings.PointSize / 2;
                        int y = (int)lineSegment.Begin.Coordinates[1] - Settings.PointSize / 2;

                        graphics.DrawEllipse(Settings.OuterPointPen, x - Settings.PointSize / 2, Height
                        - y - Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                        graphics.DrawString(lineSegment.Name, Settings.ValueFont, Settings.FontSolidBrush, x, Height - y);
                    }
                    else
                    {
                        int x1 = (int)lineSegment.Begin.Coordinates[0];
                        int y1 = (int)lineSegment.Begin.Coordinates[1];
                        int x2 = (int)lineSegment.End.Coordinates[0];
                        int y2 = (int)lineSegment.End.Coordinates[1];

                        graphics.DrawLine(Settings.LinePen, x1, Height - y1, x2, Height - y2);
                        graphics.DrawString(lineSegment.Name, Settings.ValueFont,
                        Settings.FontSolidBrush, (x1 + x2) / 2, Height - (y1 + y2) / 2);
                    }
                }
            }
        }
    }
}
