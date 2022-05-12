using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public interface IEspressoMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}

public class EspressoMakerComponent : IEspressoMakerComponent
{
    private readonly EspressoModule _module;

    public EspressoMakerComponent(EspressoModule module)
    {
        _module = module;
    }

    public CoffeeMaker CoffeeMaker => new CoffeeMaker(_module.Bean, _module.Heater);
}