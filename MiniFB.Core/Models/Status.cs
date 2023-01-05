using System.ComponentModel.DataAnnotations;
namespace MiniFB.Core.Models;

public class Status
{
    public Status(string content)
    {
        Id = new Guid();
        Content = content;
        CreatedAt = DateTime.Now;
    }

    public Guid Id { get; set; }

    [Required(ErrorMessage = "Post Content Cannot be empty")]
    public string Content { get; set; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; set; } = default;

    /*** Entity Relationships ***/
    public User User { get; } = null!; // One user per status
}