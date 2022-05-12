using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;
using Noneb.Jet.Playground.Coffee.Di;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public class ManualEspressoMakerComponent : IEspressoMakerComponent
{
    private readonly EspressoModule _module;

    public ManualEspressoMakerComponent(EspressoModule module)
    {
        _module = module;
    }

    public CoffeeMaker CoffeeMaker => new(_module.Bean, _module.Heater);
}