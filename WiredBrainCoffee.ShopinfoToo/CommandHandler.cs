// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.DataAccess.Model;

internal class CommandHandler:ICommandHandler
{
    private IEnumerable<CoffeeShop> coffeeShops;
    private string? line;

    public CommandHandler(IEnumerable<CoffeeShop> coffeeShops, string? line)
    {
        this.coffeeShops = coffeeShops;
        this.line = line;
    }

    public void HandleCommand()
    {
        var foundCoffeeShops = coffeeShops.Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase)).ToList();
        if (!foundCoffeeShops.Any())
        {
            Console.WriteLine($"> Command '{line}' not found!");
        }
        else if (foundCoffeeShops.Count == 1)
        {
            var coffeeShop = foundCoffeeShops.Single();
            Console.WriteLine($"> Location: {coffeeShop.Location}");
            Console.WriteLine($"Beans in Stock: {coffeeShop.BeansInStockInKg} kg.");
        }
        else
        {
            Console.WriteLine($"Multiple matching coffee shop commands found:");
            foreach (CoffeeShop coffeeShopFound in foundCoffeeShops)
            {
                Console.WriteLine($"> {coffeeShopFound.Location}");
            }
        }
    }
}