namespace Noneb.Jet.Core;

[AttributeUsage(AttributeTargets.Interface)]
public class RequiresAttribute : Attribute
{
    public RequiresAttribute(params Type[] modules)
    {
        Modules = modules;
    }

    public Type[] Modules { get; }
}