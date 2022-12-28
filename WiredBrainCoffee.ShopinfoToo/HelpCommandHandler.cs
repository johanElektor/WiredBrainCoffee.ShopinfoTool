// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.DataAccess.Model;

internal class HelpCommandHandler : ICommandHandler
{
    private readonly IEnumerable<CoffeeShop> coffeeShops;

    public HelpCommandHandler(IEnumerable<CoffeeShop> coffeeShops)
    {
        this.coffeeShops = coffeeShops;
    }

    public void HandleCommand()
    {
        foreach (CoffeeShop coffeeShop in coffeeShops)
        {
            Console.WriteLine($">  {coffeeShop.Location}");
        }
    }
}