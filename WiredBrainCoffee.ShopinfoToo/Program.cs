// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.DataAccess;
using WiredBrainCoffee.DataAccess.Model;

Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");
Console.WriteLine("Write 'help' to List available Coffee Shop Commands: Write 'Quit' to Exit the Application.");
var coffeeShopDataProvider = new CoffeeShopDataProvider();

while (true)
{
    var line = Console.ReadLine();

    // Break out of the while loop, if the user types 'Quit''
    if (String.Equals("quit",line,StringComparison.OrdinalIgnoreCase))
    {
        break;  
    }

    var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
    if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
    {
        foreach (CoffeeShop coffeeShop in coffeeShops)
        {
            Console.WriteLine($"> " + coffeeShop.Location);
        }
    }
    else
    {
        var foundCoffeeShops =coffeeShops.Where(x=>x.Location.StartsWith(line,StringComparison.OrdinalIgnoreCase)).ToList();
        if (!foundCoffeeShops.Any()) 
        {
            Console.WriteLine($"> Command '{line}' not found!");
        }
        else if (foundCoffeeShops.Count() == 1)
        {
            var coffeeShop = foundCoffeeShops.Single();
            Console.WriteLine($"> Location: {coffeeShop.Location}");
            Console.WriteLine($"Beans in Stock: {coffeeShop.BeansInStockInKg} kg.");
        }
        else
        {
            Console.WriteLine($"Multiple matching coffee shop commands found:");
            foreach(CoffeeShop coffeeShopFound in foundCoffeeShops )
            {
                Console.WriteLine($"> {coffeeShopFound.Location}");
            }
        }
    }
}
