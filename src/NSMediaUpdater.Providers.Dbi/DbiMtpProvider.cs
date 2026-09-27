using NSMediaUpdater.Core.Abstractions;
using NSMediaUpdater.Core.Models;

namespace NSMediaUpdater.Providers.Dbi;

/// <summary>
/// Entry point for DBI MTP integration.
/// Initial target: read-only inventory.
/// </summary>
public sealed class DbiMtpProvider : IConsoleProvider
{
    public string Name => "DBI MTP";

    public Task<bool> IsAvailableAsync(CancellationToken cancellationToken = default)
    {
        // TODO: Detect DBI via Windows Portable Devices / MTP.
        return Task.FromResult(false);
    }

    public Task<IReadOnlyList<ConsoleTitle>> GetInstalledTitlesAsync(
        CancellationToken cancellationToken = default)
    {
        // TODO: Enumerate DBI "Installed games" and normalize inventory.
        IReadOnlyList<ConsoleTitle> result = [];
        return Task.FromResult(result);
    }
}
