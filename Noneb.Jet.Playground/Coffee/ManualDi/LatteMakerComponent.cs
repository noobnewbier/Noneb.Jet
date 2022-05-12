using Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public interface ILatteMakerComponent
{
    CoffeeMaker CoffeeMaker { get; }
}

public class LatteMakerComponent : ILatteMakerComponent
{
    private readonly LatteModule _latteModule;

    public LatteMakerComponent(LatteModule latteModule)
    {
        _latteModule = latteModule;
    }

    public CoffeeMaker CoffeeMaker => new(_latteModule.Bean, _latteModule.Heater);
}