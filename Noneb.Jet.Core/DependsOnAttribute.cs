namespace Noneb.Jet.Core
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class DependsOnAttribute : Attribute
    {
        public DependsOnAttribute(params Type[] components)
        {
            Components = components;
        }

        public Type[] Components { get; }
    }
}