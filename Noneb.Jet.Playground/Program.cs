// See https://aka.ms/new-console-template for more information

using Noneb.Jet.Playground.Coffee.ManualDi;

ManualCoffeeMakerTest();

void ManualCoffeeMakerTest()
{
    var latteModule = new LatteModule();
    var latteComponent = new LatteMakerComponent(latteModule);

    var latteMaker = latteComponent.CoffeeMaker;
    latteMaker.MakeCoffee();
}

void PrintSourceGeneratorText()
{
    var text = ExampleSourceGenerated.ExampleSourceGenerated.GetTestText();
    Console.WriteLine(text);
}