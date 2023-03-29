using System.Drawing;

namespace GraphsApp.Models.Plots
{
    public interface IShape
    {
        string Name { get; set; }

        Color Color { get; set; }

        IShape Display(IPlot schedule);

        double GetMax(IPlot schedule, int axisIndex);

        double GetMin(IPlot schedule, int axisIndex);
    }
}