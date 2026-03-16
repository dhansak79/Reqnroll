namespace Reqnroll.TestProjectGenerator.Data
{
    /// <summary>
    /// Identifies a NuGet package by name and version, replacing the two consecutive
    /// <c>string</c> parameters previously passed to <see cref="ProjectBuilder.AddNuGetPackage"/>
    /// and <see cref="ProjectBuilder.UpdateNuGetPackage"/>.
    /// </summary>
    public record NuGetPackageId(string Name, string Version);
}
