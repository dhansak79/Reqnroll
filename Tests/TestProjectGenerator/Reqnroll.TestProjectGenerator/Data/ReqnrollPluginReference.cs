namespace Reqnroll.TestProjectGenerator.Data
{
    /// <summary>
    /// Identifies a Reqnroll provider plugin: the NuGet package name, the DLL file name inside
    /// that package, and the target-framework sub-path where the DLL lives.
    /// Replaces the three consecutive <c>string</c> parameters that were previously passed to
    /// <c>AddReqnrollPluginIfFeatureProject</c>.
    /// </summary>
    public record ReqnrollPluginReference(string PackageName, string AssemblyFileName, string AssemblySubPath = "net462");
}
