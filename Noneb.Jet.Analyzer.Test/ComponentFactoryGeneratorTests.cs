using System.Text;
using Microsoft.CodeAnalysis.Text;
using Xunit;
using VerifyCS = Noneb.Jet.Analyzer.Test.CSharpSourceGeneratorVerifier<Noneb.Jet.Analyzer.ComponentsGenerator>;

namespace Noneb.Jet.Analyzer.Test;

public class ComponentFactoryGeneratorTests
{
    private readonly SourceText dummyClass = SourceText.From(
        @"
public class DummyClass
{
}
",
        Encoding.UTF8
    );

    [Fact(DisplayName = "When declaring component with no dependencies. Create a factory with no dependencies")]
    public async void CreateComponentWithNoDependencies()
    {
        //todo: extract name and stuffs to share logic
        //todo: these files needs to be c# 8 compliant!
        const string source = @"namespace Dummy.Namespace;

[Component]
public interface IEmptyComponent
{
}";
        const string generatedFactory = @"using Dummy.Namespace;

namespace Noneb.Jet.Core;

public static partial class ComponentFactory
{
    public static IEmptyComponent CreateIEmptyComponent()
    {
        return new GeneratedImplOfIEmptyComponent();
    }
}";
        
        const string generatedComponent = @$"namespace Dummy.Namespace;

public class GeneratedImplOfIEmptyComponent : IEmptyComponent
{{
}}";
        
        await new VerifyCS.Test
        {
            TestState =
            {
                Sources = { source },
                GeneratedSources =
                {
                    (typeof(ComponentsGenerator), "ComponentFactory.IEmptyComponent.g.cs", SourceText.From(generatedFactory, Encoding.UTF8)),
                    (typeof(ComponentsGenerator), "GeneratedImplOfIEmptyComponent.g.cs", SourceText.From(generatedComponent, Encoding.UTF8))
                },
            },
            
            
        }.RunAsync();
    }
    
    //todo: namespace?
    //todo nested namespace?
}