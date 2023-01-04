using System.ComponentModel.DataAnnotations;
namespace MiniFB.Core.Models;

public class User 
{
    [Key]
    public string Email { get; } = null!;
    public string FirstName { get; } = null!;
    public string? LastName { get; }
    public string PassWord { get; } = null!;

    /*** Entity Relationships ***/
    public ICollection<Status> Statuses { get; } = null!; // Statuses belong to a single user
}