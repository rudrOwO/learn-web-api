using MiniFB.Core.Models;
using MiniFB.Core.Db;

namespace MiniFB.Core.Services;

public class StatusService : IStatusService
{
    private MiniFbContext _dbContext { get; }

    public StatusService(MiniFbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Status>? GetAllStatus()
        => _dbContext.Statuses;

    public void CreateStatus(Status status)
    {
        _dbContext.Add<Status>(status);
        _dbContext.SaveChanges();
    }
}