using webapi.Models;
namespace webapi.Services;

public class TaxiService : ITaxiService
{
    TaxisContext context;

    public TaxiService(TaxisContext dbcontext)
    {
        context = dbcontext;
    }

    public IEnumerable<Taxi> Get()
    {
        return context.Taxis;
    }

    public async Task Save(Taxi taxi)
    {
        context.Add(taxi);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, Taxi taxi)
    {
        var actualTaxi = context.Taxis.Find(id);

        if (actualTaxi != null)
        {
            actualTaxi.Plate = taxi.Plate;

            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        var actualTaxi = context.Taxis.Find(id);

        if (actualTaxi != null)
        {
            context.Remove(actualTaxi);
            await context.SaveChangesAsync();
        }
    }

}

public interface ITaxiService
{
    IEnumerable<Taxi> Get();
    Task Save(Taxi taxi);

    Task Update(Guid id, Taxi taxi);

    Task Delete(Guid id);
}