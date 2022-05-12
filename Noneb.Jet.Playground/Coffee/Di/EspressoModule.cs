using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public class EspressoModule
{
    public IBean Bean => new EspressoBean();
    public Heater Heater => new();
}