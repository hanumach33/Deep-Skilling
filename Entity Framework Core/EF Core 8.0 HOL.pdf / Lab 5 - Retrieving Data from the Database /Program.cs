using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            Console.WriteLine("All Products");
            Console.WriteLine();

            var products = await context.Products.ToListAsync();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ₹{product.Price}");
            }

            Console.WriteLine();

            var foundProduct = await context.Products.FindAsync(1);

            Console.WriteLine("Find By ID");

            if (foundProduct != null)
            {
                Console.WriteLine($"Found : {foundProduct.Name}");
            }

            Console.WriteLine();

            var expensiveProduct = await context.Products
                .FirstOrDefaultAsync(p => p.Price > 50000);

            Console.WriteLine("First Expensive Product");

            if (expensiveProduct != null)
            {
                Console.WriteLine($"{expensiveProduct.Name} - ₹{expensiveProduct.Price}");
            }
        }
    }
}
