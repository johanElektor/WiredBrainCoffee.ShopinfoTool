// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.DataAccess;
using WiredBrainCoffee.DataAccess.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");
        Console.WriteLine("Write 'help' to List available Coffee Shop Commands: Write 'Quit' to Exit the Application.");


        while (true)
        {
            var line = Console.ReadLine();
            var coffeeShops = CoffeeShopDataProvider.LoadCoffeeShops();


            // Break out of the while loop, if the user types 'Quit''
            if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            var commandHandler =
                string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
                ? new HelpCommandHandler(coffeeShops) as ICommandHandler
                : new CommandHandler(coffeeShops, line);


            commandHandler.HandleCommand();
        }
    }
}