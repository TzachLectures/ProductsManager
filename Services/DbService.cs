using ProductsManager.Models;

namespace ProductsManager.Services
{
    public static class DbService
    {
        public static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Description = "High-performance gaming laptop",
            Price = 1200.00m,
            Stock = 10,
            Category = "Electronics"
        },
        new Product
        {
            Id = 2,
            Name = "Smartphone",
            Description = "Latest model with advanced features",
            Price = 800.00m,
            Stock = 20,
            Category = "Electronics"
        },
        new Product
        {
            Id = 3,
            Name = "Coffee Maker",
            Description = "Automatic coffee maker with multiple settings",
            Price = 150.00m,
            Stock = 15,
            Category = "Home Appliances"
        }
    };
    }
}
