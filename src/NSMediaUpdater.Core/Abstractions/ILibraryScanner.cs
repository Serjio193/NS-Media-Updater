using NSMediaUpdater.Core.Models;

namespace NSMediaUpdater.Core.Abstractions;

public interface ILibraryScanner
{
    Task<IReadOnlyList<GamePackage>> ScanAsync(
        IEnumerable<string> roots,
        CancellationToken cancellationToken = default);
}
