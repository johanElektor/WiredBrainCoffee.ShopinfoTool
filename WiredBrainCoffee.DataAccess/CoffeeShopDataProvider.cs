using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public static IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            return new List<CoffeeShop>()
            {
                new CoffeeShop() { Location = "Frankfurt", BeansInStockInKg = 107 },
                new CoffeeShop() { Location = "Freiburg", BeansInStockInKg = 23 },
                new CoffeeShop() { Location = "Munich", BeansInStockInKg = 56 }
            };
        }
    }
}
