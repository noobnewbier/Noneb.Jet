using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public interface ILatteMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}