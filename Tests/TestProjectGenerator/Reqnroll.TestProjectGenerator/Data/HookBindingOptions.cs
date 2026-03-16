using System.Collections.Generic;

namespace Reqnroll.TestProjectGenerator.Data
{
    public record HookBindingOptions
    {
        public string EventType { get; init; }
        public string Name { get; init; }
        public string Code { get; init; } = "";
        public bool? AsyncHook { get; init; }
        public int? Order { get; init; }
        public IList<string> HookTypeAttributeTags { get; init; }
        public IList<string> MethodScopeAttributeTags { get; init; }
        public IList<string> ClassScopeAttributeTags { get; init; }
    }
}
