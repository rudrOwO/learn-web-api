namespace MiniFB.Models;

public class Status
{
    public Guid Id { get; }
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; } = default;
    public DateTime UpdatedAt { get; set; } = default;

    /*** Entity Relationships ***/
    public User User { get; } = null!; // One user per status
}