using Noneb.Jet.Playground.Coffee.Di;

namespace Noneb.Jet.Playground.Coffee.ManualDi;

public static class ManualJet
{
    public static ILatteMakerComponent CreateLatteMakerComponent(LatteModule latteModule) =>
        new ManualLatteMakerComponent(latteModule);

    public static IEspressoMakerComponent CreateEspressoMakerComponent(EspressoModule espressoModule) =>
        new ManualEspressoMakerComponent(espressoModule);
}