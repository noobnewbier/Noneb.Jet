using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.Di;

public interface IEspressoMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}