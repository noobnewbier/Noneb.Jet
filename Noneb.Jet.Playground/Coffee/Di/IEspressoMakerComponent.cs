using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public interface IEspressoMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}