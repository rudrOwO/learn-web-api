using MiniFB.Core.Models;
namespace MiniFB.Core.Services;

public interface IStatusService 
{
   public IEnumerable<Status>? GetAllStatus();
   
   public void GetStatus(Guid Id);
   public void DeleteStatus(Guid Id);

   
   public void CreateStatus(Status status);
   public void UpdateStatus(Status status);
}