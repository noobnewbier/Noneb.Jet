using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;
using Noneb.Jet.Playground.Coffee.Di;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public class ManualLatteMakerComponent : ILatteMakerComponent
{
    private readonly LatteModule _latteModule;

    public ManualLatteMakerComponent(LatteModule latteModule)
    {
        _latteModule = latteModule;
    }

    public CoffeeMaker CoffeeMaker => new(_latteModule.Bean, _latteModule.Heater);
}