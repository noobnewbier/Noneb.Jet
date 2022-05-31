namespace Noneb.Jet.Analyzer.CodeTemplates;

public static class ComponentFactoryTemplate
{
    public static string CreateComponentFactory(IEnumerable<string> dependencyNamespaces, string createdInterfaceName)
    {
        var generatedFactory =
@$"{string.Join("\n",dependencyNamespaces.Select(n => $"using {n};"))};

namespace Noneb.Jet.Core
{{
    public static partial class ComponentFactory
    {{
        public static {createdInterfaceName} Create{createdInterfaceName}()
        {{
            return new GeneratedImplOf{createdInterfaceName}();
        }}
    }}
}}";

        return generatedFactory;
    }
}