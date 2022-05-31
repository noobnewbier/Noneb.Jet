namespace Noneb.Jet.Analyzer.CodeTemplates;

public static class ComponentTemplate
{
    public static string CreateComponent(string createdInterfaceNamespace, string createdInterfaceName)
    {
        var generatedComponent = 
@$"namespace {createdInterfaceNamespace}
{{
    public class GeneratedImplOf{createdInterfaceName} : {createdInterfaceName}
    {{
    }}
}}";

        return generatedComponent;
    }
}