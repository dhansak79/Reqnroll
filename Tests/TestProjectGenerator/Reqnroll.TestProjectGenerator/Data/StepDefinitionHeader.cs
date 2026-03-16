namespace Reqnroll.TestProjectGenerator.Data
{
    /// <summary>
    /// Pairs the attribute name (step type) and regex pattern of a step binding, replacing the two
    /// leading <c>string</c> parameters that were previously passed to
    /// <see cref="ProjectBuilder.AddLoggingStepBinding"/>.
    /// </summary>
    public record StepDefinitionHeader(string AttributeName, string Regex);
}
