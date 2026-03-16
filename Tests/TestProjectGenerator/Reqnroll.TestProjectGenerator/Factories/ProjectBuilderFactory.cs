using Reqnroll.TestProjectGenerator.ConfigurationModel;
using Reqnroll.TestProjectGenerator.Data;
using Reqnroll.TestProjectGenerator.Helpers;

namespace Reqnroll.TestProjectGenerator.Factories
{
    public class ProjectBuilderFactory
    {
        protected readonly ProjectBuilderServices _projectBuilderServices;
        protected readonly TestRunConfiguration _testRunConfiguration;

        public ProjectBuilderFactory(ProjectBuilderServices projectBuilderServices, TestRunConfiguration testRunConfiguration)
        {
            _projectBuilderServices = projectBuilderServices;
            _testRunConfiguration = testRunConfiguration;
        }

        public ProjectBuilder CreateProject(string language)
        {
            return CreateProjectInternal(null, ParseProgrammingLanguage(language));
        }

        public ProjectBuilder CreateProject(string projectName, string language)
        {
            return CreateProjectInternal(projectName, ParseProgrammingLanguage(language));
        }

        public ProjectBuilder CreateProject(string projectName, ProgrammingLanguage language)
        {
            return CreateProjectInternal(projectName, language);
        }

        public ProgrammingLanguage ParseProgrammingLanguage(string input)
        {
            switch (input.ToUpper())
            {
                case "CSHARP":
                case "C#": return ParseCSharpProgrammingLanguage();
                case "VB":
                case "VB.NET":
                case "VBNET": return ProgrammingLanguage.VB;
                case "FSHARP":
                case "F#": return ProgrammingLanguage.FSharp;
                default: return ProgrammingLanguage.Other;
            }
        }

        public ProgrammingLanguage ParseCSharpProgrammingLanguage()
        {
            switch (_testRunConfiguration.TargetFramework)
            {
                case TargetFramework.Net35:
                case TargetFramework.Net45:
                case TargetFramework.Net452:
                case TargetFramework.Net461:
                case TargetFramework.Net462:
                case TargetFramework.Net471:
                case TargetFramework.Net472:
                case TargetFramework.NetStandard20:
                    return ProgrammingLanguage.CSharp73;
                default: return ProgrammingLanguage.CSharp;
            }
        }

        private ProjectBuilder CreateProjectInternal(string projectName, ProgrammingLanguage language)
        {
            var project = CreateProjectBuilder();
            project.TargetFramework = _testRunConfiguration.TargetFramework;
            project.Format = _testRunConfiguration.ProjectFormat;
            project.ConfigurationFormat = _testRunConfiguration.ConfigurationFormat;
            project.Language = language;
            project.ForceAddingExplicitReferenceToReqnrollPackage = _testRunConfiguration.ForceAddingExplicitReferenceToReqnrollPackage;

            project.Configuration.UnitTestProvider = _testRunConfiguration.UnitTestProvider;

            if (projectName.IsNotNullOrWhiteSpace())
            {
                project.ProjectName = projectName;
            }

            if (project.Configuration.UnitTestProvider == UnitTestProvider.xUnit3)
            {
                project.ProjectType = ProjectType.Exe;
            }

            return project;
        }

        protected virtual ProjectBuilder CreateProjectBuilder()
        {
            return new ProjectBuilder(_projectBuilderServices, new Configuration());
        }
    }
}
