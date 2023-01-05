namespace MiniFB.Contracts.Status;

public record CreateStatusResponse (Guid Id, string Content, DateTime CreatedAt);
public record UpdateStatusResponse (Guid Id, string Content, DateTime UpdatedAt);