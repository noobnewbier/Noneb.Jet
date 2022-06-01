using Microsoft.CodeAnalysis;

namespace Noneb.Jet.Analyzer.CodeTemplates;

public static class UsingStatementsTemplate
{
    public static string Create(IEnumerable<INamespaceSymbol> dependencies)
    {
        return dependencies
            .Select(dependency => $@"{(dependency.IsGlobalNamespace ? string.Empty : $"using {dependency.Name};")}")
            .Aggregate((current, usingStatement) => $"{current}{usingStatement}\n");
    }
}