using System.ComponentModel.DataAnnotations;
namespace MiniFB.Core.Models;

public class Status
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Post Content Cannot be empty")]
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; } = default;
    public DateTime UpdatedAt { get; set; } = default;

    /*** Entity Relationships ***/
    public User User { get; } = null!; // One user per status
}