namespace NSMediaUpdater.Core.Models;

public sealed class ConsoleTitle
{
    public required string TitleId { get; init; }
    public required string Name { get; init; }
    public ulong? InstalledVersion { get; init; }
    public string? DisplayVersion { get; init; }
    public ConsoleStorage Storage { get; init; }
    public List<string> InstalledDlcTitleIds { get; init; } = [];
}

public enum ConsoleStorage
{
    Unknown = 0,
    SdCard = 1,
    Nand = 2
}
