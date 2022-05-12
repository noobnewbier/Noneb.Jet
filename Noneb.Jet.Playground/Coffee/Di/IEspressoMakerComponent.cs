using Noneb.Jet.Core;
using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;
using Noneb.Jet.Playground.Coffee.ManualDi;

namespace Noneb.Jet.Playground.Coffee.Di;

[Requires(typeof(EspressoModule))]
public interface IEspressoMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}