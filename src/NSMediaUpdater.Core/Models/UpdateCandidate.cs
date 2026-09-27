namespace NSMediaUpdater.Core.Models;

public sealed class UpdateCandidate
{
    public required string TitleId { get; init; }
    public required string Name { get; init; }
    public ulong? InstalledVersion { get; init; }
    public ulong? AvailableVersion { get; init; }
    public string? InstalledDisplayVersion { get; init; }
    public string? AvailableDisplayVersion { get; init; }

    public bool IsUpdateAvailable =>
        AvailableVersion.HasValue &&
        (!InstalledVersion.HasValue || AvailableVersion.Value > InstalledVersion.Value);
}
