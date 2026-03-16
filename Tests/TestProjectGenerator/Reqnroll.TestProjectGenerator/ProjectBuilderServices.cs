using Reqnroll.TestProjectGenerator.Factories.BindingsGenerator;
using Reqnroll.TestProjectGenerator.Factories.ConfigurationGenerator;

namespace Reqnroll.TestProjectGenerator
{
    /// <summary>
    /// Aggregates the shared service dependencies required to construct a <see cref="ProjectBuilder"/>,
    /// replacing the equivalent individual constructor parameters on both <see cref="ProjectBuilder"/>
    /// and <see cref="Factories.ProjectBuilderFactory"/>.
    /// </summary>
    public class ProjectBuilderServices
    {
        public TestProjectFolders TestProjectFolders { get; }
        public FeatureFileGenerator FeatureFileGenerator { get; }
        public BindingsGeneratorFactory BindingsGeneratorFactory { get; }
        public ConfigurationGeneratorFactory ConfigurationGeneratorFactory { get; }
        public CurrentVersionDriver CurrentVersionDriver { get; }
        public Folders Folders { get; }
        public TargetFrameworkMonikerStringBuilder TargetFrameworkMonikerStringBuilder { get; }

        public ProjectBuilderServices(
            TestProjectFolders testProjectFolders,
            FeatureFileGenerator featureFileGenerator,
            BindingsGeneratorFactory bindingsGeneratorFactory,
            ConfigurationGeneratorFactory configurationGeneratorFactory,
            CurrentVersionDriver currentVersionDriver,
            Folders folders,
            TargetFrameworkMonikerStringBuilder targetFrameworkMonikerStringBuilder)
        {
            TestProjectFolders = testProjectFolders;
            FeatureFileGenerator = featureFileGenerator;
            BindingsGeneratorFactory = bindingsGeneratorFactory;
            ConfigurationGeneratorFactory = configurationGeneratorFactory;
            CurrentVersionDriver = currentVersionDriver;
            Folders = folders;
            TargetFrameworkMonikerStringBuilder = targetFrameworkMonikerStringBuilder;
        }
    }
}
