using System.Drawing;

using GraphsApp.Services.App;

namespace GraphsApp.Models.Plots
{
    public interface IDrawable
    {
        void Draw(Graphics graphics, Settings settings, int height, int width);
    }
}