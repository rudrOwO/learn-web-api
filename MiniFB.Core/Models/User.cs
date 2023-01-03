using System.ComponentModel.DataAnnotations;
namespace MiniFB.Models; 

public class User 
{
    [Key]
    public string Email { get; } = null!;
    public string FirstName { get; } = null!;
    public string? LastName { get; }
    private string PassWord = null!;

    /*** Entity Relationships ***/
    public ICollection<Status> Statuses { get; } = null!; // Statuses belong to a single user
}