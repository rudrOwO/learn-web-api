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
            throw new Exception("Invalid ID");
        }
        else
        {
            targetStatus.Content = status.Content;
            _dbContext.SaveChanges();
        }
    }

    public Status GetStatus(Guid Id)
    {
        var targetStatus = _dbContext.Find<Status>(Id);
    
        if (targetStatus is null)
        {
            throw new Exception("Invalid ID");
        }
        else
        {
            return targetStatus;
        }
    }

    public void DeleteStatus(Guid Id)
    {
        var targetStatus = _dbContext.Find<Status>(Id);
    
        if (targetStatus is null)
        {
            throw new Exception("Invalid ID");
        }
        else
        {
            _dbContext.Remove(targetStatus);
            _dbContext.SaveChanges();
        }
    }
}
