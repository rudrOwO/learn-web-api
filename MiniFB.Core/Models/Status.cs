namespace MiniFB.Core.Models;

public class Status
{
    public Guid Id { get; set; }
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; } = default;
    public DateTime UpdatedAt { get; set; } = default;

    /*** Entity Relationships ***/
    public User User { get; } = null!; // One user per status
}