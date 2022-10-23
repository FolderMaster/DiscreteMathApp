using System.Collections.Generic;

namespace GraphsApp.Models.Schedules
{
    public interface ISchedule
    {
        List<Axis> Axises { get; }

        List<IShape> Shapes { get; set; }

        List<IShape> Displays { get; }

        double DefaultValue { get; set; }

        double GetMin(int axisesIndex);

        double GetMax(int axisesIndex);

        void DefaultDisplay();
    }
}