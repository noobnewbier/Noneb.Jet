using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Noneb.Jet.Core;

namespace Noneb.Jet.Analyzer;

[Generator]
public class ComponentsGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
        var compilation = context.Compilation;
        foreach (var tree in compilation.SyntaxTrees)
        {
            var semanticModel = compilation.GetSemanticModel(tree, true);
            foreach (var interfaceDeclaration in tree.GetRoot().DescendantNodes().OfType<InterfaceDeclarationSyntax>())
            {
                if (!IsComponentDeclaration(semanticModel, interfaceDeclaration)) continue;

                var componentInterfaceName = interfaceDeclaration.Identifier.ToString();
                var declaredSymbol = semanticModel.GetDeclaredSymbol(interfaceDeclaration)!;
                var containingNamespace = declaredSymbol.ContainingNamespace;
                var componentImplementationName = $"GeneratedImplOf{componentInterfaceName}";

                var factorySource = CreateComponentFactory(
                    containingNamespace,
                    componentInterfaceName,
                    componentImplementationName
                );
                var componentSource = CreateComponent(
                    containingNamespace,
                    componentImplementationName,
                    componentInterfaceName
                );

                context.AddSource(
                    $"ComponentFactory.{componentInterfaceName}.g.cs",
                    SourceText.From(factorySource, Encoding.UTF8)
                );
                context.AddSource($"{componentImplementationName}.g.cs", SourceText.From(componentSource, Encoding.UTF8));
            }
        }

        // ReSharper disable once SuggestBaseTypeForParameter : has to be an interface
        bool IsComponentDeclaration(SemanticModel semanticModel, InterfaceDeclarationSyntax interfaceDeclaration)
        {
            var componentAttributeName = nameof(ComponentAttribute).Replace("Attribute", string.Empty);

            var attributes = semanticModel.GetDeclaredSymbol(interfaceDeclaration)!.GetAttributes()
                                          .Select(a => a.AttributeClass);
            var hasComponentAttribute = attributes.Any(a => a?.ToDisplayString() == componentAttributeName);

            return hasComponentAttribute;
        }
    }

    private static string CreateComponent(INamespaceSymbol containingNamespace,
                                          string componentImplementationName,
                                          string componentInterfaceName)
    {
        var usingStatements = @"";

        var body = $@"{(containingNamespace.IsGlobalNamespace ? string.Empty : $"namespace {containingNamespace};")}

public class {componentImplementationName} : {componentInterfaceName}
{{
}}";

        if (usingStatements == string.Empty) return body;

        var source = $@"{usingStatements}

{body}";
        return source;
    }

    private static string CreateComponentFactory(INamespaceSymbol? containingNamespace,
                                                 string typeIdentifier,
                                                 string componentImplementationName)
    {
        var usingStatements =
            $@"{(containingNamespace?.IsGlobalNamespace ?? true ? string.Empty : $"using {containingNamespace};")}";

        var body = $@"namespace Noneb.Jet.Core;

public static partial class {nameof(ComponentFactory)}
{{
    public static {typeIdentifier} Create{typeIdentifier}()
    {{
        return new {componentImplementationName}();
    }}
}}";

        if (usingStatements == string.Empty) return body;

        var source = $@"{usingStatements}

{body}";
        return source;
    }
}