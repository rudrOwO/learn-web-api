using MiniFB.Core.Models;
namespace MiniFB.Core.Services;

public interface IStatusService 
{
   public IEnumerable<Status>? GetAllStatus();
   public void CreateStatus(Status status);
}