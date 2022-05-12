using Noneb.Jet.Core;
using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;
using Noneb.Jet.Playground.Coffee.ManualDi;

namespace Noneb.Jet.Playground.Coffee.Di;

[Requires(typeof(LatteModule))]
public interface ILatteMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}