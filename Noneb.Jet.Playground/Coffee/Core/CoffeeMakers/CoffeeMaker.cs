namespace Noneb.Jet.Playground.Coffee.Core.CoffeeMakers;

public class CoffeeMaker
{
    private readonly IBean _bean;
    private readonly IHeater _heater;

    public CoffeeMaker(IBean bean, IHeater heater)
    {
        _bean = bean;
        _heater = heater;
    }

    public void MakeCoffee()
    {
        Console.WriteLine($"Made a coffee using {_heater.HeaterName} and {_bean.BeanName}");
    }
}