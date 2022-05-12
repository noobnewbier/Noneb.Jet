using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.Di;

public class EspressoModule
{
    public IBean Bean => new EspressoBean();
    public Heater Heater => new();
}