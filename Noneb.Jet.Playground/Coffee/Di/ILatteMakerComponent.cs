using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.Di;

public interface ILatteMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}