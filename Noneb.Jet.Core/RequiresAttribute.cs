namespace Noneb.Jet.Core
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class RequiresAttribute : Attribute
    {
        public Type[] Modules { get; }

        public RequiresAttribute(params Type[] modules)
        {
            Modules = modules;
        }
    }
}