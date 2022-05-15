using System;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Noneb.Jet.Core;

namespace Noneb.Jet.Analyzer;

[Generator]
public class ExampleSourceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        Console.WriteLine(DateTime.Now.ToString());

        var sourceBuilder = new StringBuilder(
            @"
            using System;
            namespace Noneb.Jet.Core;
            public static partial class ExampleSourceGenerated
            {
                public static string GetTestText() 
                {
                    return ""This is from source generator "
        );

        sourceBuilder.Append(DateTime.Now.ToString());

        sourceBuilder.Append(
            @""";
                }
}
"
        );

        context.AddSource("exampleSourceGenerator", SourceText.From(sourceBuilder.ToString(), Encoding.UTF8));
    }

    public void Initialize(GeneratorInitializationContext context)
    {
    }
}