using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            var product = await context.Products
                .FirstOrDefaultAsync(p => p.Name == "Laptop");

            if (product != null)
            {
                product.Price = 70000;

                await context.SaveChangesAsync();

                Console.WriteLine("Product price updated successfully.");
            }

            var toDelete = await context.Products
                .FirstOrDefaultAsync(p => p.Name == "Rice Bag");

            if (toDelete != null)
            {
                context.Products.Remove(toDelete);

                await context.SaveChangesAsync();

                Console.WriteLine("Product deleted successfully.");
            }

            Console.WriteLine();

            var products = await context.Products.ToListAsync();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - ₹{item.Price}");
            }
        }
    }
}
