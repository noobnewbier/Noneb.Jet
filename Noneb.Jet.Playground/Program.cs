using Noneb.Jet.Playground.Coffee.ManualDi;

ManualCoffeeMakerTest();

void ManualCoffeeMakerTest()
{
    var latteModule = new LatteModule();
    var latteComponent = ManualJet.CreateLatteMakerComponent(latteModule);
    var latteMaker = latteComponent.CoffeeMaker;
    latteMaker.MakeCoffee();

    var espressoModule = new EspressoModule();
    var espressoComponent = ManualJet.CreateEspressoMakerComponent(espressoModule);
    var espressoMaker = espressoComponent.CoffeeMaker;
    espressoMaker.MakeCoffee();
}

void PrintSourceGeneratorText()
{
    var text = ExampleSourceGenerated.ExampleSourceGenerated.GetTestText();
    Console.WriteLine(text);
}