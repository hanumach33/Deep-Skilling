using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    internal class Program
    {
        private static readonly Func<AppDbContext, decimal, IAsyncEnumerable<Product>>
            ExpensiveProductsQuery =
            EF.CompileAsyncQuery(
                (AppDbContext context, decimal price) =>
                    context.Products.Where(p => p.Price > price)
            );

        static async Task Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            Console.WriteLine("Products using AsNoTracking()");
            Console.WriteLine();

            var products = await context.Products
                .AsNoTracking()
                .ToListAsync();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ₹{product.Price}");
            }

            Console.WriteLine();
            Console.WriteLine("Products using Compiled Query");
            Console.WriteLine();

            await foreach (var product in ExpensiveProductsQuery(context, 10000))
            {
                Console.WriteLine($"{product.Name} - ₹{product.Price}");
            }
        }
    }
}
