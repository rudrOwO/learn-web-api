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

    public void UpdateStatus(Status status)
    {
        var targetStatus = _dbContext.Find<Status>(status.Id);

        if (targetStatus is null)
        {
            throw new Exception("Invlid ID");
        }
        else
        {
            targetStatus.Content = status.Content;
            _dbContext.SaveChanges();
        }
    }

    public void GetStatus(Guid Id)
    {
        throw new NotImplementedException();
    }

    public void DeleteStatus(Guid Id)
    {
        throw new NotImplementedException();
    }
}
