namespace GraphsApp.Models.Schedules
{
    public interface IShape
    {
        IShape Display(ISchedule schedule);

        double GetMax(ISchedule schedule, int axisIndex);

        double GetMin(ISchedule schedule, int axisIndex);
    }
}