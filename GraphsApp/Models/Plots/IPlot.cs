using System.Collections.Generic;

namespace GraphsApp.Models.Plots
{
    public interface IPlot
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