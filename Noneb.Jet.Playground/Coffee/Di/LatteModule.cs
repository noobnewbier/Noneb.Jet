using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public class LatteModule
{
    public IBean Bean => new LatteBean();
    public IHeater Heater => new Heater();
}