using webapi.Models;
namespace webapi.Services;

public class TrajectoryService : ITrajectoryService
{
    TaxisContext context;

    public TrajectoryService(TaxisContext dbcontext)
    {
        context = dbcontext;
    }

    public IEnumerable<Trajectory> Get()
    {
        return context.Trajectories;
    }

    public async Task Save(Trajectory trajectory)
    {
        context.Add(trajectory);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, Trajectory trajectory)
    {
        var actualTrajectory = context.Trajectories.Find(id);

        if (actualTrajectory != null)
        {
            actualTrajectory.TaxiId = trajectory.TaxiId;
            actualTrajectory.Date = trajectory.Date;
            actualTrajectory.Latitude = trajectory.Latitude;
            actualTrajectory.Longitude = trajectory.Longitude;

            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        var actualTrajectory = context.Trajectories.Find(id);

        if (actualTrajectory != null)
        {
            context.Remove(actualTrajectory);
            await context.SaveChangesAsync();
        }
    }
}

public interface ITrajectoryService
{
    IEnumerable<Trajectory> Get();
    Task Save(Trajectory trajectory);

    Task Update(Guid id, Trajectory trajectory);

    Task Delete(Guid id);
}