using System.Drawing;

namespace GraphsApp.Models.Schedules
{
    public interface IShape
    {
        string Name { get; set; }

        Color Color { get; set; }

        IShape Display(ISchedule schedule);

        double GetMax(ISchedule schedule, int axisIndex);

        double GetMin(ISchedule schedule, int axisIndex);
    }
}