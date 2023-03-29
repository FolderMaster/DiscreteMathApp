using System.Drawing;

namespace GraphsApp.Models.Plots
{
    public interface ICamera
    {
        Image Shot { get; }
    }
}