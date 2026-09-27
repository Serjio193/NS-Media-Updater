using NSMediaUpdater.Core.Models;

namespace NSMediaUpdater.Core.Abstractions;

public interface IConsoleProvider
{
    string Name { get; }

    Task<bool> IsAvailableAsync(CancellationToken cancellationToken = default);

    Task<IReadOnlyList<ConsoleTitle>> GetInstalledTitlesAsync(
        CancellationToken cancellationToken = default);
}
