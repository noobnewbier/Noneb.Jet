using Noneb.Jet.Core;
using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.Di;

public class EspressoModule
{
    [Provides]
    public IBean Bean => new EspressoBean();
    
    [Provides]
    public Heater Heater => new();
}