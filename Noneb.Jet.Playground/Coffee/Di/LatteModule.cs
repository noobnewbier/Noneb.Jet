using Noneb.Jet.Core;
using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.Di;

public class LatteModule
{
    [Provides]
    public IBean Bean => new LatteBean();
    
    [Provides]
    public IHeater Heater => new Heater();
}