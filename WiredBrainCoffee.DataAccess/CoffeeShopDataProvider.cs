using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            return new List<CoffeeShop>()
            {
                new CoffeeShop() { Location = "Frankfurt", BeansInStockInKg = 107, PaperCuspsinStock = 350 },
                new CoffeeShop() { Location = "Freiburg", BeansInStockInKg = 23, PaperCuspsinStock = 250},
                new CoffeeShop() { Location = "Munich", BeansInStockInKg = 56, PaperCuspsinStock = 427}
            };
        }
    }
}
