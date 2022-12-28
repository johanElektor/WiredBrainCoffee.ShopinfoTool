using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public static IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            return new List<CoffeeShop>()
            {
                new CoffeeShop() { Location = "Frankfurt", BeansInStockInKg = 107, PaperCuspsInStock = 350 },
                new CoffeeShop() { Location = "Freiburg", BeansInStockInKg = 23, PaperCuspsInStock = 250},
                new CoffeeShop() { Location = "Munich", BeansInStockInKg = 56, PaperCuspsInStock = 427}
            };
        }
    }
}
