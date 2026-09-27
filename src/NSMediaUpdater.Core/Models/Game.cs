namespace NSMediaUpdater.Core.Models;

public sealed class Game
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string? TitleId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Publisher { get; set; }
    public string? Developer { get; set; }
    public string? CoverUri { get; set; }
    public List<GamePackage> Packages { get; } = [];
}
