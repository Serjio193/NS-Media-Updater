namespace NSMediaUpdater.Core.Models;

public sealed class GamePackage
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string? TitleId { get; set; }
    public PackageType Type { get; set; }
    public string? DisplayVersion { get; set; }
    public ulong? InternalVersion { get; set; }
    public string? Path { get; set; }
    public long Size { get; set; }
    public string? Hash { get; set; }
}

public enum PackageType
{
    Unknown = 0,
    BaseGame = 1,
    Update = 2,
    Dlc = 3,
    Translation = 4,
    Mod = 5
}
