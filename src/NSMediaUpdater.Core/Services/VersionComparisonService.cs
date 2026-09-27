using NSMediaUpdater.Core.Models;

namespace NSMediaUpdater.Core.Services;

public sealed class VersionComparisonService
{
    public UpdateCandidate Compare(
        ConsoleTitle installed,
        string availableName,
        ulong? availableVersion,
        string? availableDisplayVersion)
    {
        ArgumentNullException.ThrowIfNull(installed);

        return new UpdateCandidate
        {
            TitleId = installed.TitleId,
            Name = availableName,
            InstalledVersion = installed.InstalledVersion,
            AvailableVersion = availableVersion,
            InstalledDisplayVersion = installed.DisplayVersion,
            AvailableDisplayVersion = availableDisplayVersion
        };
    }
}
