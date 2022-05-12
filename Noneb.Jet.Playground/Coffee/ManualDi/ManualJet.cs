namespace Noneb.Jet.Playground.Coffee.ManualDi;

public static class ManualJet
{
    public static ILatteMakerComponent CreateLatteMakerComponent(LatteModule latteModule) => new LatteMakerComponent(latteModule);

    public static IEspressoMakerComponent CreateEspressoMakerComponent(EspressoModule espressoModule) =>
        new EspressoMakerComponent(espressoModule);
}