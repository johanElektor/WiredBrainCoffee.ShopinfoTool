namespace WiredBrainCoffee.DataAccess.Model
{
    public  class CoffeeShop
    {
        public string Location { get; set; }
        public int BeansInStockInKg { get; set; }
        public int PaperCuspsInStock { get; set; }  

        public string? ManagerName { get; set; }
    }
}
