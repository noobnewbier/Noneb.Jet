using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.Di;

public class LatteModule
{
    public IBean Bean => new LatteBean();
    public IHeater Heater => new Heater();
}