namespace GraphsApp.Models.Plots
{
    public interface IScale
    {
        double Display(double value, double min, double max, double length);
    }
}