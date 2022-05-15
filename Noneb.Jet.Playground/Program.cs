using Noneb.Jet.Core;
using Noneb.Jet.Playground.Coffee.Di;
using Noneb.Jet.Playground.Coffee.ManualDi;

ManualCoffeeMakerTest();
void ManualCoffeeMakerTest()
{
    var latteModule = new LatteModule();
    var latteComponent = ManualComponentFactory.CreateLatteMakerComponent(latteModule);
    var latteMaker = latteComponent.CoffeeMaker;
    latteMaker.MakeCoffee();

    var espressoModule = new EspressoModule();
    var espressoComponent = ManualComponentFactory.CreateEspressoMakerComponent(espressoModule);
    var espressoMaker = espressoComponent.CoffeeMaker;
    espressoMaker.MakeCoffee();
}

void PrintSourceGeneratorText()
{
    var text = ExampleSourceGenerated.GetTestText();
    Console.WriteLine(text);
}

