namespace Reqnroll.TestProjectGenerator.Data
{
    /// <summary>
    /// Pairs the CSharp and VB.NET implementations of a step binding, replacing the two
    /// consecutive <c>string</c> parameters that were previously passed to
    /// <see cref="ProjectBuilder.AddStepBinding"/>.
    /// </summary>
    public record LanguageSpecificCode(string CSharp, string VBNet);
}
